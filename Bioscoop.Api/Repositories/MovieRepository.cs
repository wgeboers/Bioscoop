using Bioscoop.Api.Data;
using Bioscoop.Api.Entities;
using Bioscoop.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Api.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly BioscoopDbContext bioscoopDbContext;

        public MovieRepository(BioscoopDbContext bioscoopDbContext)
        {
            this.bioscoopDbContext = bioscoopDbContext;
        }

        public Task<Movie> GetMovie(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movies = await bioscoopDbContext.Movies.ToListAsync();

            return movies;
        }
    }
}
