using Bioscoop.Api.Data;
using Bioscoop.Api.Repositories;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Test.Api.Ticket
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
            if (await databaseContext.Tickets.CountAsync() <= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    databaseContext.Tickets.Add(
                    new Bioscoop.Api.Entities.Ticket()
                    {
                        Id = 1,
                        Code = 1,
                        ShowId = 1,
                        RowNumber = 5,
                        SeatNumber = 12,
                        Price = 8.50m
                    });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }

        [Fact]
        public async void TicketRepository_GetTicket_ReturnsTicket()
        {
            //Arrange
            var id = 1;
            var dbContext = await GetDatabaseContext();
            var ticketRepository = new TicketRepository(dbContext);

            //Act
            var result = ticketRepository.GetTicket(id);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<Bioscoop.Api.Entities.Ticket>();
        }

        [Fact]
        public async void TicketRepository_GetTicketByCode_ReturnsTicket()
        {
            //Arrange
            var code = 1;
            var dbContext = await GetDatabaseContext();
            var ticketRepository = new TicketRepository(dbContext);

            //Act
            var result = ticketRepository.GetTicketByCode(code);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<Bioscoop.Api.Entities.Ticket>();
        }
    }
}
