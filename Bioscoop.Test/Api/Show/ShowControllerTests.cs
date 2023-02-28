using Bioscoop.Api.Controllers;
using Bioscoop.Api.Repositories;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace Bioscoop.Test.Api.Show
{
    public class TicketControllerTests
    {
        private readonly IShowRepository _showRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IRoomRepository _roomRepository;

        public TicketControllerTests()
        {
            _showRepository = A.Fake<IShowRepository>();
            _movieRepository = A.Fake<IMovieRepository>();
            _roomRepository = A.Fake<IRoomRepository>();
        }

        [Fact]
        public async void ShowController_GetShows_ReturnOK()
        {
            //Arrange
            var controller = new ShowController(_showRepository, _movieRepository, _roomRepository);

            //Act
            var result = await controller.GetShows();

            //Assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async void ShowController_CreateShow_ReturnCreatedAtActionResult()
        {
            //Arrange
            var show = A.Fake<ShowToAddDto>();
            var controller = new ShowController(_showRepository, _movieRepository, _roomRepository);

            //Act
            var result = await controller.PostShow(show);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<CreatedAtActionResult>();
        }
    }
}
