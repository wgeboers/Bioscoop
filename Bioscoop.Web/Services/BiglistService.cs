using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using System.Net.Http.Json;

namespace Bioscoop.Web.Services
{
    public class BiglistService : IBiglistService
    {
        private readonly HttpClient httpClient;

        public BiglistService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            
        }
        public async Task <ShowDto> GetShow(int id)
        {
            try
            {
                var showlist = await this.httpClient.GetAsync($"api/Show/{id}");

                if (showlist.IsSuccessStatusCode)
                {
                    if (showlist.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(ShowDto);
                    }

                    return await showlist.Content.ReadFromJsonAsync<ShowDto>();
                }
                else
                {
                    var message = await showlist.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception){
                throw;
            }
        }

        
        public async Task<IEnumerable<ShowDto>> GetShows()
        {
            try
            {
                var showlist = await this.httpClient.GetAsync("api/Show");

                if (showlist.IsSuccessStatusCode)
                {
                    if (showlist.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ShowDto>(); 
                    }
                    return await showlist.Content.ReadFromJsonAsync<IEnumerable<ShowDto>>();
                }
                else
                {
                    var message = await showlist.Content.ReadAsStringAsync();
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
