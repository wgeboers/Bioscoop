using Bioscoop.Web.Services.Contracts;
using Bioscoop.Models.Dtos;
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

        public async Task<MovieDto> GetMovie(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Movie/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(MovieDto);
                    }

                    return await response.Content.ReadFromJsonAsync<MovieDto>();
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

        public async Task<IEnumerable<MovieDto>> GetMovies()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/Movie");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<MovieDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<MovieDto>>();
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
