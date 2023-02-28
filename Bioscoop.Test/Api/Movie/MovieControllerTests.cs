using Bioscoop.Api.Controllers;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace Bioscoop.Test.Api.Movie
{
    public class RoomControllerTests
    {
        private readonly IMovieRepository _movieRepository;

        public RoomControllerTests()
        {
            _movieRepository = A.Fake<IMovieRepository>();
        }

        [Fact]
        public async void MovieController_GetMovies_ReturnOK()
        {
            //Arrange
            var controller = new MovieController(_movieRepository);

            //Act
            var result = await controller.GetMovies();

            //Assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async void MovieController_CreateMovie_ReturnCreatedAtActionResult()
        {
            //Arrange
            var movie = A.Fake<MovieToAddDto>();
            var controller = new MovieController(_movieRepository);

            //Act
            var result = await controller.PostMovie(movie);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<CreatedAtActionResult>();
        }
    }
}
