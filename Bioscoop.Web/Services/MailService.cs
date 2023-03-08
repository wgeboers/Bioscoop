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

        public async Task<String> EmailTicketByte(MailDataWithAttachmentByte mailData)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("api/Mail/sendemailwithattachmentbyte", mailData);

                if (response.IsSuccessStatusCode)
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

#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async void Nothing()
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {

        }
    }
}
