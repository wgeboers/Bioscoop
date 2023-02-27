using Bioscoop.Api.Data;
using Bioscoop.Api.Entities;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
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

        public async Task<Movie> GetMovie(int id)
        {
            var movie = await bioscoopDbContext.Movies.FindAsync(id);
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movies = await bioscoopDbContext.Movies.ToListAsync();

            return movies;
        }

        public async Task<Movie> AddMovie(MovieToAddDto movieToAddDto)
        {
            var result = await this.bioscoopDbContext.Movies.AddAsync(new Movie
                                                                     {
                                                                         Title = movieToAddDto.Title,
                                                                         Description = movieToAddDto.Description,
                                                                         ImageURL = movieToAddDto.ImageURL,
                                                                         PlayTime = movieToAddDto.PlayTime,
                                                                         MinimumAge = movieToAddDto.MinimumAge,
                                                                     });
            await this.bioscoopDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await this.bioscoopDbContext.Movies.FindAsync(id);

            if (movie != null)
            {
                this.bioscoopDbContext.Movies.Remove(movie);
                await this.bioscoopDbContext.SaveChangesAsync();
            }

            return movie;
        }
    }
}
