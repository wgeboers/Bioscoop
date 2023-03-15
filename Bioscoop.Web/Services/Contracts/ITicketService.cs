using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface ITicketService
    {
        Task<TicketDto> GetTicket(int id);
        Task<TicketDto> AddTicket(TicketToAddDto ticketToAddDto);
        Task<IEnumerable<TicketDto>> GetTicketsByShow(int id);
        Task<TicketDto> GetTicketByCode(int id);
        Task<TicketDto> AddSecretTicket(TicketToAddDto ticketToAddDto);
    }
}
