using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface ITicketService
    {
        Task<IEnumerable<TicketDto>> GetTickets(int showId);
        Task<TicketDto> AddTicket(TicketToAddDto ticketToAddDto);
    }
}
