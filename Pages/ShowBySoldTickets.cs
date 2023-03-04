using Microsoft.AspNetCore.Components;
using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;


namespace Bioscoop.Web.Pages
{
    public class ShowBySoldTickets : ComponentBase
    {
        [Parameter]
        public int TicketId { get; set; }
        public int ShowId { get; set; }
        [Inject]
        public ITicketService TicketService { get; set; }


        [Inject]
        public IManageTicketsLocalStorageService ManageTicketLocalStorageService { get; set; }

        public IEnumerable<TicketDto> Tickets { get; set; }
        public string ShowId { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                Shows = await GetTicketCollectionId(ShowId);

                if (Shows != null && Shows.Count() > 0)
                {
                    var TicketDto = Tickets.FirstOrDefault(t => t.ShowId == ShowId);

                    if (TicketDto <30 )
                    {
                        ShowId = TicketDto.ShowId;
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        private async Task<IEnumerable<TicketDto>> GetShowBySoldTickets(int ShowId)
        {
            var ticketCollection = await ManageTicketLocalStorageService.GetCollection();

            if (ticketCollection != null)
            {
                return ticketCollection.Where(t => t.ShowId == showId);
            }
            else
            {
                return await TicketService.ShowBySoldTickets(ShowId);
            }

        }

    }
}
