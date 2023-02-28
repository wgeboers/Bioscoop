using Bioscoop.Api.Controllers;
using Bioscoop.Api.Repositories;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace Bioscoop.Test.Api.Ticket
{
    public class TicketControllerTests
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IShowRepository _showRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRoomRepository _roomRepository;

        public TicketControllerTests()
        {
            _ticketRepository = A.Fake<ITicketRepository>();
            _showRepository = A.Fake<IShowRepository>();
            _movieRepository = A.Fake<IMovieRepository>();
            _roomRepository = A.Fake<IRoomRepository>();
        }

        [Fact]
        public async void TicketController_GetTickets_ReturnOK()
        {
            //Arrange
            var controller = new TicketController(_ticketRepository, _showRepository, _movieRepository, _roomRepository);

            //Act
            var result = await controller.GetTickets();

            //Assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async void TicketController_CreateTicket_ReturnCreatedAtActionResult()
        {
            //Arrange
            var ticket = A.Fake<TicketToAddDto>();
            var controller = new TicketController(_ticketRepository, _showRepository, _movieRepository, _roomRepository);

            //Act
            var result = await controller.PostTicket(ticket);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<CreatedAtActionResult>();
        }
    }
}
