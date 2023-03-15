using Mollie.Api.Client;
using Mollie.Api.Client.Abstract;
using Mollie.Api.Models.Payment.Request;
using Mollie.Api.Models;
using Mollie.Api.Models.Payment.Response;
using Mollie.Api.Models.PaymentLink.Response;
using Mollie.Api.Models.PaymentLink.Request;
using Bioscoop.Models.Dtos;
using Mollie.Api.Models.Payment;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Api.Data;

namespace Bioscoop.Api.Services
{
    public class PaymentService : IPaymentService
    {
        private IPaymentClient _client;
        private PaymentLinkClient _linkClient;
        private ITicketRepository _ticketRepository;

        public PaymentService(ITicketRepository repository)
        {
            _client = new PaymentClient("test_eFqumDpmpUyVvxytTq937e3sW7h8ak");
            _linkClient = new PaymentLinkClient("test_eFqumDpmpUyVvxytTq937e3sW7h8ak");
            _ticketRepository = repository;
        }
        public async Task<PaymentDto> MakePayment(decimal amount, TicketDto ticket)
        {
            //Create Payment
            PaymentRequest paymentRequest = new PaymentRequest()
             {
                 Amount = new Amount(Currency.EUR, amount),
                 Description = "Payment for movie ticket",
                 RedirectUrl = "https://localhost:7235/TicketDetails/" + ticket.Id,
                 CancelUrl = "https://localhost:7235/TicketDetails?message=Cancelled",
                 Methods = new List<string>() {
                     PaymentMethod.Ideal,
                     PaymentMethod.CreditCard
                 }
             };

            PaymentResponse paymentResponse = await _client.CreatePaymentAsync(paymentRequest);
            _ticketRepository.UpdateTicketPayment(ticket.Id, paymentResponse.Id);
            
            var link = paymentResponse.Links;
            var paymentLink = link.Checkout.Href;
            return new PaymentDto
            {
                Status = paymentResponse.Status,
                PaymentLink = paymentLink,
                PaymentID= paymentResponse.Id,
            };            
        }

        public async Task<PaymentDto> GetPaymentInfo(string paymentID)
        {
            PaymentResponse result;
            try
            {
                result = await _client.GetPaymentAsync(paymentID);
            }
            catch (Exception)
            {

                return default(PaymentDto);
            }
            
            var link = result.Links;
            string? paymentLink = null;
            if (link.Checkout != null)
            {
                paymentLink = link.Checkout.Href;
            }
            
            return new PaymentDto
            {
                Status = result.Status,
                PaymentLink = paymentLink,
                PaymentID= result.Id,
            };
        }
    }
}
