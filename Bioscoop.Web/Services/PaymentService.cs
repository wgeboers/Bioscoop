using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using System.Net.Http;
using System.Net.Http.Json;

namespace Bioscoop.Web.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient httpClient;

        public PaymentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        internal static string GetPaymentLink(object paymentID)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentDto> GetPaymentLink(string paymentID)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Payment/getpaymentlink/{paymentID}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(PaymentDto);
                    }

                    return await response.Content.ReadFromJsonAsync<PaymentDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status:{response.StatusCode} Message -{message}");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<PaymentDto> MakePayment(decimal amount, TicketDto ticket)
        {

            try
            {
                var response = await httpClient.PostAsJsonAsync<TicketDto>("api/Payment/makepayment", ticket);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(PaymentDto);
                    }

                    return await response.Content.ReadFromJsonAsync<PaymentDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status:{response.StatusCode} Message -{message}");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
