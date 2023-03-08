using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class ShowDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
#pragma warning disable CS8618 // Non-nullable property 'ShowService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public IShowService ShowService { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ShowService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Show' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public ShowDto Show { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Show' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

#pragma warning disable CS8618 // Non-nullable property 'ErrorMessage' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string ErrorMessage { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ErrorMessage' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Show = await ShowService.GetShow(Id);
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }
    }
}