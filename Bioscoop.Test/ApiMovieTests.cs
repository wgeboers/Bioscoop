using Bioscoop.Api.Controllers;
using Bioscoop.Api.Entities;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Bioscoop.Test
{
    public class ApiMovieTests
    {
        [Fact]
        public async void ReturnOkGetMovies()
        {
            // Arrange
            var mockRepository = new Mock<IMovieRepository>();
            var controller = new MovieController(mockRepository.Object);
            
            //Act
            var response = await controller.GetMovies();

            //Assert
            Assert.IsType<OkObjectResult>(response.Result);
            
        }

        [Fact]
        public async void PostMovie()
        {
            // Arrange
            var mockRepository = new Mock<IMovieRepository>();
            var controller = new MovieController(mockRepository.Object);

            MovieToAddDto movie = new MovieToAddDto()
            {
                Title = "Shrek",
                Description = "Description",
                ImageURL = "/Images/Shrek.jpg",
                PlayTime = 89,
                MinimumAge = 9
            };

            //Act
            var response = await controller.PostMovie(movie);

            //Assert
            Assert.IsType<CreatedAtActionResult>(response.Result);

        }
    }
}
