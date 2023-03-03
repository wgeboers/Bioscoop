using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.pages
{
    public class BiglistBase : ComponentBase
    {
        [Inject]
        public IBiglistService BiglistService { get; set; }
        public IEnumerable<ShowDto> Shows { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Shows = await BiglistService.GetShows();
        }

    }
}
