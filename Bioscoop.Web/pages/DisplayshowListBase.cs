using Microsoft.AspNetCore.Components;
using Bioscoop.Models.Dtos;


namespace Bioscoop.Web.pages
{
    public class DisplayshowListBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ShowDto> Shows { get; set; }
    }
}
