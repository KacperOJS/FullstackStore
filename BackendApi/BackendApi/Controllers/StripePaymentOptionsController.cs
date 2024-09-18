using BackendApi.data;
using BackendApi.models;
using BackendApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Stripe.Checkout;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly DataContext _context;

    public PaymentsController(IConfiguration config, DataContext context)
    {
        _config = config;
        _context = context;
        StripeConfiguration.ApiKey = config["Stripe:SecretKey"];
    }

    [HttpPost("create-checkout-session")]
    public async Task<IActionResult> CreateCheckoutSession()
    {
        string requestBody;
        using (var reader = new StreamReader(Request.Body))
        {
            requestBody = await reader.ReadToEndAsync();
        }

        dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(requestBody);

        var lineItems = new List<SessionLineItemOptions>();
        foreach (var item in data.lineItems)
        {
            lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    Currency = item.priceData.currency,
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = item.priceData.productData.name
                    },
                    UnitAmount = item.priceData.unitAmount,
                },
                Quantity = item.quantity
            });
        }

        var options = new SessionCreateOptions
        {
            LineItems = lineItems,
            Mode = "payment",
            SuccessUrl = data.successUrl,
            CancelUrl = data.cancelUrl,
            // Add metadata to store finduserbyid
            Metadata = new Dictionary<string, string>
            {
                { "finduserbyid", data.finduserbyid.ToString() } // Ensure it is converted to string
            }
        };

        var service = new SessionService();

        try
        {
            Session session = await service.CreateAsync(options);

            // Return the session URL and include finduserbyid in the response
            return Ok(new { url = session.Url, finduserbyid = data.finduserbyid });
        }
        catch (StripeException e)
        {
            return BadRequest(new { error = e.Message });
        }
    }

    [HttpPost("webhook")]
    public async Task<IActionResult> HandleStripeWebhook()
    {
        // Read the request body
        string json;
        using (var reader = new StreamReader(Request.Body))
        {
            json = await reader.ReadToEndAsync();
        }

        // Ensure Stripe-Signature header is present
        if (!Request.Headers.ContainsKey("Stripe-Signature"))
        {
            return BadRequest(new { error = "Stripe-Signature header is missing." });
        }

        // Ensure the webhook secret is configured
        var webhookSecret = _config["Stripe:WebhookSecret"];
        if (string.IsNullOrEmpty(webhookSecret))
        {
            return StatusCode(500, new { error = "Webhook secret is not configured." });
        }

        Event stripeEvent;
        try
        {
            stripeEvent = EventUtility.ConstructEvent(
                json,
                Request.Headers["Stripe-Signature"],
                webhookSecret
            );
        }
        catch (StripeException e)
        {
            return BadRequest(new { error = e.Message });
        }

        // Process the event
        if (stripeEvent.Type == Events.CheckoutSessionCompleted)
        {
            try
            {
                var session = stripeEvent.Data.Object as Session;

                // Retrieve finduserbyid from metadata

                


                var finduserbyid = session.Metadata["finduserbyid"];
     
               
                // Retrieve the PaymentIntent associated with the session
                var paymentIntentId = session.PaymentIntentId;
                var paymentIntentService = new PaymentIntentService();
                var paymentIntent = await paymentIntentService.GetAsync(paymentIntentId);


           



                var totalAmountSpent = paymentIntent.AmountReceived / 100; // Divide by 100 to remove last two zeros


                var paymentLog = new LogsOfPaymentCustomer
                {
                    Date = DateTime.UtcNow,
                    Amount = (int)totalAmountSpent,
                    Status = PaymentStatus.Completed, // Assuming the payment is completed
                    Customer = await _context.Customers.FirstOrDefaultAsync(c => c.id == int.Parse(finduserbyid))
                };

                await _context.PaymentLog.AddAsync(paymentLog);
                await _context.SaveChangesAsync();

                // Find and update the customer



                var customer = await _context.Customers
                    .FirstOrDefaultAsync(c => c.id == int.Parse(finduserbyid));
                if (customer != null)
                {
                  
                    // Update the customer's spend
                    customer.Spend = (customer.Spend ?? 0) + (int)totalAmountSpent;
                  

                    // Update the customer in the database
                    _context.Customers.Update(customer);
                    await _context.SaveChangesAsync();

                    Console.WriteLine("Customer spend updated.");
                }
                else
                {
                    Console.WriteLine("Customer not found.");
                }
            }
            catch (Exception e)
            {
                // Log or handle exceptions as needed
                Console.WriteLine($"Error updating customer phone: {e.Message}");
                return StatusCode(500, new { error = e.Message });
            }
        }
        else
        {
            // Log unhandled event types
            Console.WriteLine($"Unhandled event type: {stripeEvent.Type}");
        }

        return Ok();
    }
}
