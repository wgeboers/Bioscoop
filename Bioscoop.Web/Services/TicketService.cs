using Bioscoop.Models.Dtos;
using System.Net.Http.Json;

namespace Bioscoop.Web.Services.Contracts
{
    public class TicketService : ITicketService
    {
        private readonly HttpClient httpClient;

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
                        return default(TicketDto);
                    }

                    return await response.Content.ReadFromJsonAsync<TicketDto>();
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

        public async Task<TicketDto> GetTicketByCode(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Ticket/code/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(TicketDto);
                    }

                    return await response.Content.ReadFromJsonAsync<TicketDto>();
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

        public async Task<TicketDto> AddTicket(TicketToAddDto ticketToAddDto)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync<TicketToAddDto>("api/Ticket", ticketToAddDto);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(TicketDto);
                    }

                    return await response.Content.ReadFromJsonAsync<TicketDto>();

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

        public async Task<TicketDto> AddSecretTicket(TicketToAddDto ticketToAddDto)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync<TicketToAddDto>("api/Ticket/secret", ticketToAddDto);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(TicketDto);
                    }

                    return await response.Content.ReadFromJsonAsync<TicketDto>();

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

        public async Task<IEnumerable<TicketDto>> GetTicketsByShow(int id)
        {
            try
            {
                var response = await this.httpClient.GetAsync($"api/Ticket/TicketsByShow/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<TicketDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<TicketDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
