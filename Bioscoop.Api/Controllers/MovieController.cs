using Bioscoop.Api.Entities;
using Bioscoop.Api.Extensions;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace Bioscoop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovies()
        {
            try
            {
                var movies = await this.movieRepository.GetMovies();

                if (movies == null)
                {
                    return NotFound();
                }
                else
                {
                    var movieDtos = movies.ConvertToDto();
                    return Ok(movieDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<MovieDto>> GetMovie(int id)
        {
            try
            {
                var movie = await this.movieRepository.GetMovie(id);

                if (movie == null)
                {
                    return BadRequest();
                }
                else
                {
                    var movieDto = movie.ConvertToDto();
                    return Ok(movieDto);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<MovieDto>> PostMovie([FromBody] MovieToAddDto movieToAddDto)
        {
            try
            {
                var newMovie = await this.movieRepository.AddMovie(movieToAddDto);
                if (newMovie == null)
                {
                    return NoContent();
                }

                var newMovieDto = newMovie.ConvertToDto();

                return CreatedAtAction(nameof(GetMovie), new { id = newMovieDto.Id }, newMovieDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Movie>> DeleteMovie(int id)
        {
            try
            {
                var movie = await this.movieRepository.DeleteMovie(id);
                if (movie == null)
                {
                    return NotFound();
                }

                return Ok(movie);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }
    }
}
