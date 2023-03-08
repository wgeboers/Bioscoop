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

        public string ErrorMessage { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Shows = await ShowService.GetShows();
        }
    }
}