using Bioscoop.Models.Dtos;
using Bioscoop.Models.Models;
using Bioscoop.Web.Services;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Bioscoop.Web.Pages
{
    public class ShowsAllBase : ComponentBase
    {
        [Inject]
        public IShowService ShowService { get; set; }
        [Inject]
        public ITicketService TicketService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IPaymentService PaymentService { get; set; }
        public IEnumerable<ShowDto> Shows { get; set; }
        public IEnumerable<string> Genres { get; set; }
        public IEnumerable<int> Ages { get; set; }
        public PaymentDto Payment { get; set; }
        public TicketDto Ticket { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Shows = await ShowService.GetShows();
            Genres = Shows.Select(x => x.MovieGenre).Distinct();
            Ages = Shows.Select(x => x.MovieMinimumAge).Distinct();
        }

        protected async Task AddSecretTicket_ForShow(TicketToAddDto ticketToAddDto)
        {
            try
            {
                var ticketDto = await TicketService.AddSecretTicket(ticketToAddDto);
                var ticketid = ticketDto.Id;

                NavigationManager.NavigateTo($"/TicketDetails/{ticketid}");

            }
            catch (Exception ex)
            {

            }
        }
    }
}