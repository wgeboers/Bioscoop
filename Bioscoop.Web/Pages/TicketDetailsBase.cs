using Bioscoop.Models.Dtos;
using Bioscoop.Models.Models;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class TicketDetailsBase : ComponentBase 
    {
        [Parameter]
        public int? Id { get; set; }

        [Inject]
        public ITicketService TicketService { get; set; }
        [Inject]
        public IMailService MailService { get; set; }
        public TicketDto Ticket { get; set; }

        public MailData mailData { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                try
                {
                    Ticket = await TicketService.GetTicket((int)Id);
                    if (Ticket.Secret == true)
                    {
                        //Add check for language to change secret....
                        Ticket.Price -= 2.50m;
                        Ticket.MovieTitle = "Secret";
                    }
                }
                catch (Exception ex)
                {

                    ErrorMessage = ex.Message;
                }
            }
        }

    }
}
