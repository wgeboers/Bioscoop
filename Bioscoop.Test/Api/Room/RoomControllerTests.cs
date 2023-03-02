using Bioscoop.Api.Controllers;
using Bioscoop.Api.Repositories;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace Bioscoop.Test.Api.Room
{
    public class RoomControllerTests
    {
        private readonly IRoomRepository _roomRepository;

        public RoomControllerTests()
        {
            _roomRepository = A.Fake<IRoomRepository>();
        }

        [Fact]
        public async void RoomController_GetRooms_ReturnOK()
        {
            //Arrange
            var controller = new RoomController(_roomRepository);

            //Act
            var result = await controller.GetRooms();

            //Assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async void RoomController_CreateRoom_ReturnCreatedAtActionResult()
        {
            //Arrange
            var room = A.Fake<RoomToAddDto>();
            var controller = new RoomController(_roomRepository);

            //Act
            var result = await controller.PostRoom(room);

            //
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<CreatedAtActionResult>();
        }
    }
}
