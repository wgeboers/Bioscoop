using Bioscoop.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class DisplayShowsTodayBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ShowDto> Shows { get; set; }
    }
}