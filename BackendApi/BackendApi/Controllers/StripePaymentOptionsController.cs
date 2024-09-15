using BackendApi.data;
using BackendApi.models;
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
        var metadata = new Dictionary<string, string>
                {
                    { "userId", data.userId.ToString() } // Assuming data.userId contains the ID you want to pass
                };
        var options = new SessionCreateOptions
        {
            LineItems = lineItems,
            Mode = "payment",
            SuccessUrl = data.successUrl,
            CancelUrl = data.cancelUrl,
            Metadata = metadata,
        };

        var service = new SessionService();

        try
        {
            Session session = await service.CreateAsync(options);

            return Ok(new { url = session.Url });
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
                // Update phone number for customer with id = 1
                var session = stripeEvent.Data.Object as Session;
                if (session != null)
                {
                    Console.WriteLine($"Webhook received with Metadata: {Newtonsoft.Json.JsonConvert.SerializeObject(session.finduserbyid)}"); // Log metadata

                    var userId = session.Metadata.ContainsKey("userId")
                        ? int.Parse(session.Metadata["userId"])
                        : -1;

                    var customer = await _context.Customers
                        .FirstOrDefaultAsync(c => c.id == userId);

                    if (customer != null)
                    {
                        customer.phone = "MISKA2";
                        _context.Customers.Update(customer);
                        await _context.SaveChangesAsync();
                        Console.WriteLine("Customer phone updated to MISKA.");
                    }
                    else
                    {
                        Console.WriteLine($"Customer not found with ID: {userId}");
                    }
                }
                else
                {
                    Console.WriteLine("Session object is null.");
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

