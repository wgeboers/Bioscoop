using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class TicketShopBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IShowService ShowService { get; set; }

        [Inject]
        public ITicketService TicketService { get; set; }


        public ShowDto Show { get; set; }
        public IEnumerable<TicketDto> Tickets { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Show = await ShowService.GetShow(Id);
                Tickets = await TicketService.GetTicketsByShow(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected async Task AddTicket_ForShow(TicketToAddDto ticketToAddDto)
        {
            try
            {
                var ticketDto = await TicketService.AddTicket(ticketToAddDto);
                var ticketid = ticketDto.Id;

                NavigationManager.NavigateTo($"/TicketDetails/{ticketid}");
            }
            catch (Exception)
            {

                //Log Exception
            }
        }
    }
}