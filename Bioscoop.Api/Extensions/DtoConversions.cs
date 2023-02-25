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
    }
}
