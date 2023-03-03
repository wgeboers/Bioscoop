using Bioscoop.Models.Models;
using Bioscoop.Web.Services.Contracts;
using System.Net.Http.Json;

namespace Bioscoop.Web.Services
{
    public class MailService : IMailService
    {
        public readonly HttpClient httpClient;

        public MailService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<String> EmailTicket(MailData mailData)
        {
           try
            {
                var response = await httpClient.PostAsJsonAsync("api/Mail/sendmail", mailData);

                if(response.IsSuccessStatusCode)
                {
                    return "Mail succesfully send";

                }

                return "Failure sending e-mail, print the ticket instead.";
                    
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async void Nothing()
        {

        }
    }
}
