//using BackendApi.data;
//using BackendApi.models;
//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace BackendApi.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class PaypalPaymentOptionsController:ControllerBase
//    {
//        private readonly DataContext _context;
//        private readonly IConfiguration _configuration;
//        public PaypalPaymentOptionsController(DataContext context , IConfiguration configuration)
//        {
//            _context = context;
//            _configuration = configuration;
//        }
//        [HttpPost("create")]
//        public IActionResult CreatePayment([FromBody] PaymentRequest request)
//        {
//            // Get PayPal configuration
//            var clientId = _configuration["PayPal:ClientId"];
//            var clientSecret = _configuration["PayPal:ClientSecret"];
//            var mode = _configuration["PayPal:Mode"];

//            // Configure PayPal API context
//            var apiContext = new APIContext(new OAuthTokenCredential(clientId, clientSecret).GetAccessToken())
//            {
//                Config = { { "mode", mode } }
//            };

//            // Create a payment object
//            var payment = new Payment()
//            {
//                intent = "sale",
//                payer = new Payer() { payment_method = "paypal" },
//                redirect_urls = new RedirectURLs()
//                {
//                    cancel_url = "http://localhost:3000/cancel", // Your cancel URL
//                    return_url = "http://localhost:3000/success" // Your return URL
//                },
//                transactions = new List<Transaction>()
//                {
//                    new Transaction()
//                    {
//                        description = "Transaction description",
//                        invoice_number = Guid.NewGuid().ToString(), // Unique invoice number
//                        amount = new Amount()
//                        {
//                            currency = "USD", // Change currency as needed
//                            total = request.Amount.ToString("0.00") // Total amount
//                        }
//                    }
//                }
//            };

//            // Create payment
//            var createdPayment = payment.Create(apiContext);
//            return Ok(new { id = createdPayment.id }); // Return the created payment ID
//        }

//        [HttpPost("capture/{orderID}")]
//        public IActionResult CapturePayment(string orderID)
//        {
//            var clientId = _configuration["PayPal:ClientId"];
//            var clientSecret = _configuration["PayPal:ClientSecret"];
//            var mode = _configuration["PayPal:Mode"];

//            var apiContext = new APIContext(new OAuthTokenCredential(clientId, clientSecret).GetAccessToken())
//            {
//                Config = { { "mode", mode } }
//            };

//            var payment = Payment.Get(apiContext, orderID);
//            var executedPayment = payment.Execute(apiContext, new PaymentExecution() { payer_id = payment.payer.payer_info.payer_id });

//            return Ok(executedPayment); // Return the captured payment details
//        }
//    }


    
//}
