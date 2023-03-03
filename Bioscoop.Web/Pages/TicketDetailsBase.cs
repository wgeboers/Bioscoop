﻿using Bioscoop.Models.Dtos;
using Bioscoop.Models.Models;
using Bioscoop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Bioscoop.Web.Pages
{
    public class TicketDetailsBase : ComponentBase 
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public ITicketService TicketService { get; set; }
        [Inject]
        public IMailService MailService { get; set; }
        public TicketDto Ticket { get; set; }

        public MailData mailData { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Ticket = await TicketService.GetTicket(Id);
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }

    }
}
