using Bioscoop.Api.Entities;
using Bioscoop.Models.Dtos;

namespace Bioscoop.Api.Repositories.Contracts
{
    public interface IMovieRepository
    {
        Task<Movie> AddMovie(MovieToAddDto movieToAddDto);
        Task<Movie> DeleteMovie(int id);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(int id);
    }
}
