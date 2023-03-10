using Bioscoop.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bioscoop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
             _paymentService= paymentService;
        }

        [HttpPost("makepayment")]
        public async Task MakePayment(decimal amount)
        {
            await _paymentService.MakePayment(amount);
        }
    }
}
