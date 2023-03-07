using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface ITicketService
    {
        Task<TicketDto> GetTicket(int id);
    }
}
