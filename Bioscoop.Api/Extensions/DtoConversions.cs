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
                        MinimumAge = movie.MinimumAge,
                    }).ToList();
        }
    }
}
