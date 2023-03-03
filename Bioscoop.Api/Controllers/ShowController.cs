using Bioscoop.Api.Entities;
using Bioscoop.Api.Extensions;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bioscoop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly IShowRepository showRepository;
        private readonly IMovieRepository movieRepository;
        private readonly IRoomRepository roomRepository;

        public ShowController(IShowRepository showRepository,
                              IMovieRepository movieRepository,
                              IRoomRepository roomRepository)
        {
            this.showRepository = showRepository;
            this.movieRepository = movieRepository;
            this.roomRepository = roomRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShowDto>>> GetShows()
        {
            try
            {
                var shows = await this.showRepository.GetShows();
                if (shows == null)
                {
                    return NoContent();
                }

                var movies = await this.movieRepository.GetMovies();
                if (movies == null)
                {
                    throw new Exception("No movies exist in the system?");
                }

                var rooms = await this.roomRepository.GetRooms();
                if (rooms == null)
                {
                    throw new Exception("No rooms exist in the system?");
                }

                var showsDto = shows.ConvertToDto(movies, rooms);
                return Ok(showsDto);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ShowDto>> GetShow(int id)
        {
            try
            {
                var show = await this.showRepository.GetShow(id);
                if (show == null)
                {
                    return NotFound();
                }

                var movie = await this.movieRepository.GetMovie(show.MovieId);
                if (movie == null)
                {
                    return NotFound();
                }

                var room = await this.roomRepository.GetRoom(show.RoomId);
                if (room == null)
                {
                    return NotFound();
                }

                var showDto = show.ConvertToDto(movie, room);

                return Ok(showDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<ShowDto>> PostShow([FromBody] ShowToAddDto showToAddDto)
        {
            try
            {
                var newShow = await this.showRepository.AddShow(showToAddDto);
                if (newShow == null)
                {
                    return NoContent();
                }

                var movie = await movieRepository.GetMovie(newShow.MovieId);
                if (movie == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve movie (movieId:({newShow.MovieId})");
                }

                var room = await roomRepository.GetRoom(newShow.RoomId);
                if (room == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve room (movieId:({newShow.RoomId})");
                }

                var newShowDto = newShow.ConvertToDto(movie, room);

                return CreatedAtAction(nameof(GetShow), new { id = newShowDto.Id }, newShowDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Show>> DeleteShow(int id)
        {
            try
            {
                var show = await this.showRepository.DeleteShow(id);
                if (show == null)
                {
                    return NotFound();
                }

                return Ok(show);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error retrieving data from the database");
            }
        }
    }
}
