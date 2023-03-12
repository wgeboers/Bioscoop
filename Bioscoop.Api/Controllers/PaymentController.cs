using Azure;
using Bioscoop.Api.Data;
using Bioscoop.Api.Services;
using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mollie.Api.Models;
using Mollie.Api.Models.Payment.Response;

namespace Bioscoop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly BioscoopDbContext _dbContext;

        public PaymentController(IPaymentService paymentService, BioscoopDbContext dbContext)
        {
             _paymentService= paymentService;
            _dbContext = dbContext;
        }

        [HttpPost("makepayment")]
        public async Task<ActionResult<PaymentDto>> MakePayment([FromBody] TicketDto ticket)
        {
            try
            {
                var response = await _paymentService.MakePayment(ticket.Price, ticket);

                if (response == null)
                {
                    return NoContent();
                }
                return Ok(response);
            }
            catch (Exception)
            {

                throw;
            }           
                
        }

        [HttpGet("getpaymentlink/{paymentID}")]
        public async Task<ActionResult<PaymentDto>> GetPaymentInfo(string paymentID)
        {
            try
            {
                var response = await _paymentService.GetPaymentInfo(paymentID);

                if (response == null)
                {
                    return NoContent();
                }

                return Ok(response);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
