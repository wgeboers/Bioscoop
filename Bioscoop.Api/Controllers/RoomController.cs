using Bioscoop.Api.Entities;
using Bioscoop.Api.Extensions;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Bioscoop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepository roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomDto>>> GetRooms()
        {
            try
            {
                var rooms = await this.roomRepository.GetRooms();

                if (rooms == null)
                {
                    return NotFound();
                }
                else
                {
                    var roomDtos = rooms.ConvertToDto();
                    return Ok(roomDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<RoomDto>> GetRoom(int id)
        {
            try
            {
                var room = await this.roomRepository.GetRoom(id);

                if (room == null)
                {
                    return BadRequest();
                }
                else
                {
                    var roomDto = room.ConvertToDto();
                    return Ok(roomDto);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<RoomDto>> PostRoom([FromBody] RoomToAddDto roomToAddDto)
        {
            try
            {
                var newRoom = await this.roomRepository.AddRoom(roomToAddDto);
                if (newRoom == null)
                {
                    return NoContent();
                }

                var newRoomDto = newRoom.ConvertToDto();

                return CreatedAtAction(nameof(GetRoom), new { id = newRoomDto.Id }, newRoomDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Room>> DeleteRoom(int id)
        {
            try
            {
                var room = await this.roomRepository.DeleteRoom(id);
                if (room == null)
                {
                    return NotFound();
                }

                return Ok(room);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }
    }
}
