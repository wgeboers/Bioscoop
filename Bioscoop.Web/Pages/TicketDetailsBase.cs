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
#pragma warning disable CS8618 // Non-nullable property 'TicketService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public ITicketService TicketService { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'TicketService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        [Inject]
#pragma warning disable CS8618 // Non-nullable property 'MailService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public IMailService MailService { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'MailService' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Ticket' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public TicketDto Ticket { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Ticket' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

#pragma warning disable CS8618 // Non-nullable property 'mailData' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public MailData mailData { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'mailData' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

#pragma warning disable CS8618 // Non-nullable property 'ErrorMessage' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string ErrorMessage { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ErrorMessage' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                try
                {
#pragma warning disable CS8629 // Nullable value type may be null.
                    Ticket = await TicketService.GetTicket((int)Id);
#pragma warning restore CS8629 // Nullable value type may be null.
                }
                catch (Exception ex)
                {

                    ErrorMessage = ex.Message;
                }
            }
        }

    }
}
