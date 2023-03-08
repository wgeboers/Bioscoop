using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class MovieDetailsBase:ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
#pragma warning disable CS8618 // Non-nullable property 'MovieService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public IMovieService MovieService { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'MovieService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

#pragma warning disable CS8618 // Non-nullable property 'Movie' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public MovieDto Movie { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Movie' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

#pragma warning disable CS8618 // Non-nullable property 'ErrorMessage' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string ErrorMessage { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ErrorMessage' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Movie = await MovieService.GetMovie(Id);
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }
    }
}
