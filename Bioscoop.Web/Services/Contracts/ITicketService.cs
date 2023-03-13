using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface ITicketService
    {
        Task<TicketDto> GetTicket(int id);
        Task<IEnumerable<TicketDto>> GetTickets(int showId);
        Task<TicketDto> AddTicket(TicketToAddDto ticketToAddDto);

        Task<TicketDto> GetTicketByCode(int id);
    }
}
