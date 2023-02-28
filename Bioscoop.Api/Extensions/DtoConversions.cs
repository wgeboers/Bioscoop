using Bioscoop.Api.Entities;
using Bioscoop.Models.Dtos;

namespace Bioscoop.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<MovieDto> ConvertToDto(this IEnumerable<Movie> movies)
        {
            return (from movie in movies
                    select new MovieDto
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Description = movie.Description,
                        ImageURL = movie.ImageURL,
                        PlayTime = movie.PlayTime,
                        MinimumAge = movie.MinimumAge
                    }).ToList();
        }

        public static MovieDto ConvertToDto(this Movie movie)
        {
            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                ImageURL = movie.ImageURL,
                PlayTime = movie.PlayTime,
                MinimumAge = movie.MinimumAge
            };
        }

        public static IEnumerable<RoomDto> ConvertToDto(this IEnumerable<Room> rooms)
        {
            return (from room in rooms
                    select new RoomDto
                    {
                        Id = room.Id,
                        Name = room.Name,
                        Seats = room.Seats,
                        Rows = room.Rows,
                        WheelchairFriendly = room.WheelchairFriendly,
                    }).ToList();
        }

        public static RoomDto ConvertToDto(this Room room)
        {
            return new RoomDto
            {
                Id = room.Id,
                Name = room.Name,
                Seats = room.Seats,
                Rows = room.Rows,
                WheelchairFriendly = room.WheelchairFriendly,
            };
        }

        public static IEnumerable<ShowDto> ConvertToDto(this IEnumerable<Show> shows)
        {
            return (from show in shows
                    select new ShowDto
                    {
                        Id = show.Id,
                        MovieId = show.MovieId,
                        RoomId = show.RoomId,
                        StartDateTime = show.StartDateTime,
                    }).ToList();
        }

        public static ShowDto ConvertToDto(this Show show)
        {
            return new ShowDto
            {
                Id = show.Id,
                MovieId = show.MovieId,
                RoomId = show.RoomId,
                StartDateTime = show.StartDateTime,
            };
        }


        public static IEnumerable<TicketDto> ConvertToDto(this IEnumerable<Ticket> tickets,
                                                               IEnumerable<Show> shows,
                                                               IEnumerable<Movie> movies,
                                                               IEnumerable<Room> rooms)
        {
            return (from ticket in tickets
                    join show in shows on ticket.ShowId equals show.Id
                    join movie in movies on show.MovieId equals movie.Id
                    join room in rooms on show.RoomId equals room.Id
                    select new TicketDto
                    {
                        Id = ticket.Id,
                        Code = ticket.Code,
                        ShowId = ticket.ShowId,
                        ShowStartDateTime = show.StartDateTime,
                        MovieId = show.MovieId,
                        MovieTitle = movie.Title,
                        MoviePlayTime = movie.PlayTime,
                        RoomId = show.RoomId,
                        RoomName = room.Name,
                        RowNumber = ticket.RowNumber,
                        SeatNumber = ticket.SeatNumber,
                        Price = ticket.Price
                    }).ToList();
        }

        public static TicketDto ConvertToDto(this Ticket ticket,
                                                  Show show,
                                                  Movie movie,
                                                  Room room)
        {
            return new TicketDto
            {
                Id = ticket.Id,
                Code = ticket.Code,
                ShowId = ticket.ShowId,
                ShowStartDateTime = show.StartDateTime,
                MovieId = show.MovieId,
                MovieTitle = movie.Title,
                MoviePlayTime = movie.PlayTime,
                RoomId = show.RoomId,
                RoomName = room.Name,
                RowNumber = ticket.RowNumber,
                SeatNumber = ticket.SeatNumber,
                Price = ticket.Price
            };
        }
    }
}
