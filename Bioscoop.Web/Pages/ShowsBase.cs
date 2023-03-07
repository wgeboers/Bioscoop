using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class ShowsBase : ComponentBase
    {
        [Inject]
        public IShowService ShowService { get; set; }
        public IEnumerable<ShowDto> Shows { get; set; }
        public IEnumerable<string> Genres { get; set; }
        public IEnumerable<int> Ages { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Shows = await ShowService.GetShows();
            Genres = Shows.Select(x => x.MovieGenre).Distinct();
            Ages = Shows.Select(x => x.MovieMinimumAge).Distinct();
        }
    }
}