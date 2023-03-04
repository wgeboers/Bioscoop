using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class DisplayMoviesBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ShowDto> Movies { get; set; }
    }
}
