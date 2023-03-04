using Bioscoop.Api.Data;
using Bioscoop.Api.Repositories;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Test.Api.Movie
{
    public class RoomRepositoryTests
    {
        private async Task<BioscoopDbContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<BioscoopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new BioscoopDbContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.Movies.CountAsync() <= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    databaseContext.Movies.Add(
                    new Bioscoop.Api.Entities.Movie()
                    {
                        Id = 1,
                        Title = "Shrek",
                        Description = "Groen ventje",
                        Genre = "Comedy",
                        Type = "2D",
                        ImageURL = "/Images/Shrek.jpg",
                        PlayTime = 95,
                        MinimumAge = 9,
                        special = false
                    });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }

        [Fact]
        public async void MovieRepository_GetMovie_ReturnsMovie()
        {
            //Arrange
            var id = 1;
            var dbContext = await GetDatabaseContext();
            var movieRepository = new MovieRepository(dbContext);

            //Act
            var result = movieRepository.GetMovie(id);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<Bioscoop.Api.Entities.Movie>();
        }
    }
}
