using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using System.Net.Http.Json;

namespace Bioscoop.Web.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient httpClient;

        public MovieService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        async Task<IEnumerable<ShowDto>> IMovieService.GetShows()
        {
            try
            {
                var movies = await this.httpClient.GetFromJsonAsync<IEnumerable<ShowDto>>("api/Show");
                return movies;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
