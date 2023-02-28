using Bioscoop.Api.Data;
using Bioscoop.Api.Repositories;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Test.Api.Room
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
            if (await databaseContext.Rooms.CountAsync() <= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    databaseContext.Rooms.Add(
                    new Bioscoop.Api.Entities.Room()
                    {
                        Id = 1,
                        Name = "Zaal 1",
                        Seats = 120,
                        Rows = 8,
                        WheelchairFriendly = true,
                    });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }

        [Fact]
        public async void RoomRepository_GetRoom_ReturnsRoom()
        {
            //Arrange
            var id = 1;
            var dbContext = await GetDatabaseContext();
            var roomRepository = new RoomRepository(dbContext);

            //Act
            var result = roomRepository.GetRoom(id);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<Bioscoop.Api.Entities.Room>();
        }
    }
}
