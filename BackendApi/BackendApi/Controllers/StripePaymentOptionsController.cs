using BackendApi.data;
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

    public PaymentsController(IConfiguration config,DataContext context)
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
                    var session = (Checkout.Session)stripeEvent.Data.Object;

                    // Extract customer email or ID from the session
                    var customerEmail = session.CustomerEmail; // Use CustomerEmail if available
                                                               // Alternatively, fetch the customer ID and look up the email or other details if needed
                    var customerId = session.CustomerId;

                    // Update premium points for the customer in your database
                    var customer = await _context.Customers
                        .FirstOrDefaultAsync(c => c.Email == customerEmail || c.StripeCustomerId == customerId);

                    if (customer != null)
                    {
                        // Update the customer's premium points
                        customer.PremiumPoints += 10; // Example: add 10 points (update as needed)

                        _context.Customers.Update(customer);
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
