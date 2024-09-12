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

        var options = new SessionCreateOptions
        {
            LineItems = lineItems,
            Mode = "payment",
            SuccessUrl = data.successUrl,
            CancelUrl = data.cancelUrl,
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
        // Ensure that Request.Body is not null
        if (Request.Body == null)
        {
            return BadRequest(new { error = "Request body is null." });
        }

        string json;
        using (var reader = new StreamReader(Request.Body))
        {
            json = await reader.ReadToEndAsync();
        }

        // Ensure that Request.Headers and Stripe-Signature header are not null
        if (Request.Headers["Stripe-Signature"].Count == 0)
        {
            return BadRequest(new { error = "Stripe-Signature header is missing." });
        }

        // Ensure _config is not null and contains the necessary configuration
        if (_config == null || string.IsNullOrEmpty(_config["Stripe:WebhookSecret"]))
        {
            return StatusCode(500, new { error = "Webhook secret is not configured." });
        }

        Event stripeEvent;
        try
        {
            stripeEvent = EventUtility.ConstructEvent(
                json,
                Request.Headers["Stripe-Signature"],
                _config["Stripe:WebhookSecret"]
            );
        }
        catch (StripeException e)
        {
            return BadRequest(new { error = e.Message });
        }

        try
        {
            // Process the event
            switch (stripeEvent.Type)
            {
                case Events.CheckoutSessionCompleted:
                    var session = (Stripe.Checkout.Session)stripeEvent.Data.Object;

                    // Extract customer details
                    var customerEmail = session.CustomerEmail;
                    var customerId = session.CustomerId;
                    var paymentIntentId = session.PaymentIntentId;
                    var amountTotal = session.AmountTotal; // Total amount in cents
                    var currency = session.Currency;
                    var paymentStatus = session.PaymentStatus;

                    // Find the customer in your database by their email
                    var customer = await _context.Customers
                        .FirstOrDefaultAsync(c => c.email == customerEmail);

                    if (customer != null)
                    {
                        // Update the customer's premium points (or any other field)
                        customer.phone = "MISKA"; // Example update

                        // Save payment data in the Payments table
                        var paymentRecord = new Payment
                        {
                            CustomerId = customerId,
                            PaymentIntentId = paymentIntentId,
                            Amount = (decimal)amountTotal,  // Store amount in your preferred format (convert to PLN)
                            Currency = currency,
                            PaymentStatus = paymentStatus,
                            CreatedAt = DateTime.UtcNow
                        };

                        // Save both customer updates and payment details
                        _context.Customers.Update(customer);
                        _context.Payments.Add(paymentRecord);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        // Handle case where customer is not found
                        return NotFound(new { error = "Customer not found." });
                    }
                    break;

                // Handle other event types if needed
                default:
                    Console.WriteLine($"Unhandled event type: {stripeEvent.Type}");
                    break;
            }

            return Ok();
        }
        catch (Exception e)
        {
            // Log or handle exceptions as needed
            return StatusCode(500, new { error = e.Message });
        }
    }
}

