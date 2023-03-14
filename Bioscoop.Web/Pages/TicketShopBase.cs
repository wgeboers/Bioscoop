using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

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

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        public ShowDto Show { get; set; }
        public IEnumerable<TicketDto> Tickets { get; set; }
        public string ErrorMessage { get; set; }

        public List<Seat> Seats { get; set; }

        public List<Seat> SelectedSeats { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Show = await ShowService.GetShow(Id);
                Tickets = await TicketService.GetTicketsByShow(Id);
                Seats = new List<Seat>();
                SelectedSeats = new List<Seat>();
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

        public class Seat
        {
            public int seatnr { get; set; }
            public int rownr { get; set; }
            public string type { get; set; }

            public Seat(int seatnrCon, int rownrCon, string type)
            {
                this.seatnr = seatnrCon;
                this.rownr = rownrCon;
                this.type = type;
            }
        }
    }
}