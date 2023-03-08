using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class MoviesBase:ComponentBase
    {
        [Inject]
#pragma warning disable CS8618 // Non-nullable property 'MovieService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public IMovieService MovieService { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'MovieService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

#pragma warning disable CS8618 // Non-nullable property 'Movies' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public IEnumerable<MovieDto> Movies { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Movies' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        protected override async Task OnInitializedAsync()
        {
            Movies = await MovieService.GetMovies();
        }
    }
}
