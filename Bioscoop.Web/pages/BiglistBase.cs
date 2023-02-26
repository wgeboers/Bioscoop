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

        public IEnumerable<MovieDto> Movies { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Movies = await BiglistService.GetMovies();
        }
    }
}
