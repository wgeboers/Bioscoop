using Bioscoop.Api.Entities;
using Bioscoop.Models.Dtos;

namespace Bioscoop.Api.Repositories.Contracts
{
    public interface ITicketRepository
    {
        Task<Ticket> AddTicket(TicketToAddDto ticketToAddDto);
        Task<Ticket> DeleteTicket(int id);
        Task<IEnumerable<Ticket>> GetTickets();
        Task<Ticket> GetTicket(int id);
        Task<Ticket> GetTicketByCode(int code);
        Task<IEnumerable<Ticket>> GetTicketsByShowId(int showId);
        Task<Option> GetOption(int id);
        Task GetOption(decimal Price);
    }
}
