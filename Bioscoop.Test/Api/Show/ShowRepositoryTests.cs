using Bioscoop.Api.Data;
using Bioscoop.Api.Repositories;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Test.Api.Show
{
    public class TicketRepositoryTests
    {
        private async Task<BioscoopDbContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<BioscoopDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new BioscoopDbContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.Shows.CountAsync() <= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    databaseContext.Shows.Add(
                    new Bioscoop.Api.Entities.Show()
                    {
                        Id = 1,
                        MovieId = 1,
                        RoomId = 1,
                        StartDateTime = DateTime.Now,
                        Type = "3D"
                    });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }

        [Fact]
        public async void ShowRepository_GetShow_ReturnsShow()
        {
            //Arrange
            var id = 1;
            var dbContext = await GetDatabaseContext();
            var showRepository = new ShowRepository(dbContext);

            //Act
            var result = showRepository.GetShow(id);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<Bioscoop.Api.Entities.Show>();
        }
    }
}
