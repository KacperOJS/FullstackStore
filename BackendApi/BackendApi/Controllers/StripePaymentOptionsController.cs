using Microsoft.AspNetCore.Mvc;
using Stripe;

[ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    [HttpPost("create-payment-intent")]
    public async Task<IActionResult> CreatePaymentIntent([FromBody] CreatePaymentRequest request)
    {
        // Create payment intent options
        var options = new PaymentIntentCreateOptions
        {
            Amount = request.Amount, // Amount in cents
            Currency = "pln", // Currency code
            PaymentMethodTypes = new List<string> { "card" }, // Specify payment method type
            Confirm = true, // Automatically confirm the payment
        };

        var service = new PaymentIntentService();
        try
        {
            // Create the payment intent
            var paymentIntent = await service.CreateAsync(options);
            return Ok(new { clientSecret = paymentIntent.ClientSecret }); // Return client secret
        }
        catch (StripeException e)
        {
            // Handle Stripe exceptions
            return BadRequest(new { error = e.StripeError.Message });
        }
    }
}

// Request model for payment
public class CreatePaymentRequest
{
    public long Amount { get; set; } // Amount in cents
    public string PaymentMethodId { get; set; } // Payment method ID from Stripe
}