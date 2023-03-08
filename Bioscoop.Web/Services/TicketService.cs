using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using System.Net.Http.Json;

namespace Bioscoop.Web.Services
{
    public class TicketService : ITicketService
    {
		public readonly HttpClient httpClient;

		public TicketService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}
        public async Task<TicketDto> GetTicket(int id)
        {
			try
			{
				var response = await httpClient.GetAsync($"api/Ticket/{id}");

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
					{
#pragma warning disable CS8603 // Possible null reference return.
						return default(TicketDto);
#pragma warning restore CS8603 // Possible null reference return.
					}

#pragma warning disable CS8603 // Possible null reference return.
					return await response.Content.ReadFromJsonAsync<TicketDto>();
#pragma warning restore CS8603 // Possible null reference return.
				}
				else
				{
					var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }
            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
