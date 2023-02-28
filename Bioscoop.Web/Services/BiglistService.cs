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
        public async Task <IEnumerable<ShowDto>> GetMovies(IEnumerable<ShowDto>? movies)
        {
            try
            {
                var Movies = await this.httpClient.GetFromJsonAsync<IEnumerable<ShowDto>>("api/Show");
                return movies;
            }
            catch (Exception){
                throw;
            }
        }

        
    }
}
