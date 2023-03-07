[HttpPost]
public async Task<ActionResult<TicketDto>> PostTicket([FromBody] TicketToAddDto ticketToAddDto)
{
    try
    {
        var tickets = await ticketRepository.GetTickets();
        var ticketCountByShowId = new Dictionary<int, int>();
        foreach (var ticket in tickets)
        {
            if (!ticketCountByShowId.ContainsKey(ticket.ShowId))
            {
                ticketCountByShowId[ticket.ShowId] = 1;
            }
            else
            {
                ticketCountByShowId[ticket.ShowId]++;
            }
        }

        var showIdWithMostTickets = ticketCountByShowId.OrderByDescending(pair => pair.Value).FirstOrDefault().Key;

        var newTicket = await ticketRepository.AddTicket(new Ticket { ShowId = showIdWithMostTickets });

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

        var newTicketDto = newTicket.ConvertToDto(show, movie, room);

        return CreatedAtAction(nameof(GetTicket), new { id = newTicketDto.Id }, newTicketDto);
    }
    catch (Exception)
    {
        return StatusCode(StatusCodes.Status500InternalServerError,
            "Error retrieving data from the database");
    }
}
