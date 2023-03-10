using Mollie.Api.Client;
using Mollie.Api.Client.Abstract;
using Mollie.Api.Models.Payment.Request;
using Mollie.Api.Models;
using Mollie.Api.Models.Payment.Response;

namespace Bioscoop.Api.Services
{
    public class PaymentService : IPaymentService
    {
        private IPaymentClient _client;

        public PaymentService()
        {
            _client = new PaymentClient("test_eFqumDpmpUyVvxytTq937e3sW7h8ak");
        }
        public async Task MakePayment(decimal amount)
        {
            //Create Payment
            PaymentRequest paymentRequest = new PaymentRequest()
            {
                Amount = new Amount(Currency.EUR, 100.00m),
                Description = "Test payment of the example project",
                RedirectUrl = "http://google.com",
                Method = Mollie.Api.Models.Payment.PaymentMethod.Ideal // instead of "Ideal"
            };
            PaymentResponse paymentResponse = await _client.CreatePaymentAsync(paymentRequest);
            PaymentResponse result = await _client.GetPaymentAsync("id");
            
        }
    }
}
