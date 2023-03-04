using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class MoviesBase:ComponentBase
    {
        [Inject]
        public IMovieService MovieService { get; set; }

        public IEnumerable<MovieDto> Movies { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Movies = await MovieService.GetMovies();
        }
    }
}
