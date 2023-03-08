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
                        return default(ShowDto);
                    }

                    return await response.Content.ReadFromJsonAsync<ShowDto>();
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

                    return await response.Content.ReadFromJsonAsync<IEnumerable<ShowDto>>();
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