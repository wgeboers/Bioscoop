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
        public async Task <IEnumerable<MovieDto>> GetMovies()
        {
            try
            {
                var Movies = await this.httpClient.GetFromJsonAsync<IEnumerable<MovieDto>>("api/Movie");
                return Movies;
            }
            catch (Exception){
                throw;
            }
        }

        
    }
}
