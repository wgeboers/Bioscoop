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
        public IShowService ShowService { get; set; }

        [Inject]
        public ITicketService TicketService { get; set; }
        public ShowDto Show { get; set; }

        private List<TicketDto> Tickets { get; set; }

        public string ErrorMessage { get; set; }

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

        protected async Task AddTicket_ForShow(TicketToAddDto ticketToAddDto)
        {
            try
            {
                var ticketDto = await TicketService.AddTicket(ticketToAddDto);
            }
            catch (Exception)
            {

                //Log Exception
            }
        }
    }
}