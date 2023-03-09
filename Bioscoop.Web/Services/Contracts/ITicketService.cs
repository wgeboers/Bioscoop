using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface ITicketService
    {
        Task<TicketDto> AddTicket(TicketToAddDto ticketToAddDto);
        Task<TicketDto> GetTicket(int id);
    }
}
