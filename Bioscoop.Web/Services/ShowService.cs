using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using System.Net.Http.Json;

namespace Bioscoop.Web.Services
{
    public class ShowService : IShowService
    {
        private readonly HttpClient httpClient;

        public ShowService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ShowDto> GetShow(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Show/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
#pragma warning disable CS8603 // Possible null reference return.
                        return default(ShowDto);
#pragma warning restore CS8603 // Possible null reference return.
                    }

#pragma warning disable CS8603 // Possible null reference return.
                    return await response.Content.ReadFromJsonAsync<ShowDto>();
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
                //Log exception
                throw;
            }
        }

        public async Task<IEnumerable<ShowDto>> GetShows()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/Show");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ShowDto>();
                    }

#pragma warning disable CS8603 // Possible null reference return.
                    return await response.Content.ReadFromJsonAsync<IEnumerable<ShowDto>>();
#pragma warning restore CS8603 // Possible null reference return.
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }
    }
}