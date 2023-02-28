using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.pages
{
    public class BiglistBase:ComponentBase
    {
        [Inject]
        public IBiglistService BiglistService { get; set; }

        private IEnumerable<ShowDto>? movies;

        public IEnumerable<ShowDto> GetMovies()
        {
            return movies;
        }

        public void SetMovies(IEnumerable<ShowDto> value)
        {
            movies = value;
        }

        protected override async Task OnInitializedAsync()
        {
            SetMovies(await BiglistService.GetMovies(Movies));
        }
    }
}
