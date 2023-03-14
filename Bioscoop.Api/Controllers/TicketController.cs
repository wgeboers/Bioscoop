﻿using Bioscoop.Api.Entities;
using Bioscoop.Api.Extensions;
using Bioscoop.Api.Repositories.Contracts;
using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bioscoop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository ticketRepository;
        private readonly IShowRepository showRepository;
        private readonly IMovieRepository movieRepository;
        private readonly IRoomRepository roomRepository;

        public TicketController(ITicketRepository ticketRepository, 
                                IShowRepository showRepository,
                                IMovieRepository movieRepository,
                                IRoomRepository roomRepository)
        {
            this.ticketRepository = ticketRepository;
            this.showRepository = showRepository;
            this.movieRepository = movieRepository;
            this.roomRepository = roomRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetTickets()
        {
            try
            {
                var tickets = await this.ticketRepository.GetTickets();
                if (tickets == null)
                {
                    return NoContent();
                }

                var shows = await this.showRepository.GetShows();
                if (shows == null)
                {
                    throw new Exception("No shows exist in the system?");
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

                var specialsPrice = await this.ticketRepository.GetSpecialsPrice();
                if (specialsPrice == null)
                {
                    throw new Exception("no options");
                }

                var ticketsDto = tickets.ConvertToDto(shows, movies, rooms, specialsPrice);

                return Ok(ticketsDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TicketDto>> GetTicket(int id)
        {
            try
            {
                var ticket = await this.ticketRepository.GetTicket(id);
                if (ticket == null)
                {
                    return NotFound();
                }

                var show = await this.showRepository.GetShow(ticket.ShowId);
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
                var specialsPrice = await this.ticketRepository.GetSpecialsPrice();
                if (specialsPrice == null)
                {
                    throw new Exception("no options");
                }

                var ticketDto = ticket.ConvertToDto(show, movie, room, specialsPrice);

                return Ok(ticketDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("code/{code:int}")]
        public async Task<ActionResult<TicketDto>> GetTicketByCode(int code)
        {
            try
            {
                var ticket = await this.ticketRepository.GetTicketByCode(code);
                if (ticket == null)
                {
                    return NotFound();
                }

                var show = await this.showRepository.GetShow(ticket.ShowId);
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
                var specialsPrice = await this.ticketRepository.GetSpecialsPrice();
                if (specialsPrice == null)
                {
                    throw new Exception("no options");
                }

                var ticketDto = ticket.ConvertToDto(show, movie, room, specialsPrice);

                return Ok(ticketDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<TicketDto>> PostTicket([FromBody] TicketToAddDto ticketToAddDto)
        {
            try
            {
                var newTicket = await this.ticketRepository.AddTicket(ticketToAddDto);
                if (newTicket == null)
                {
                    return NoContent();
                }

                var show = await showRepository.GetShow(newTicket.ShowId);
                if (show == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve show (showId:({newTicket.ShowId})");
                }

                var movie = await movieRepository.GetMovie(show.MovieId);
                if (movie == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve movie (movieId:({show.MovieId})");
                }

                var room = await roomRepository.GetRoom(show.RoomId);
                if (room == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve room (roomId:({show.RoomId})");
                }

                var specialsPrice = await this.ticketRepository.GetSpecialsPrice();
                if (specialsPrice == null)
                {
                    throw new Exception("no options");
                }

                var newTicketDto = newTicket.ConvertToDto(show, movie, room, specialsPrice);

                return CreatedAtAction(nameof(GetTicket), new { id = newTicketDto.Id }, newTicketDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Ticket>> DeleteTicket(int id)
        {
            try
            {
                var ticket = await this.ticketRepository.DeleteTicket(id);
                if (ticket == null)
                {
                    return NotFound();
                }

                return Ok(ticket);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error retrieving data from the database");
            }
        }
    }
}
