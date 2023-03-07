using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface IShowService
    {
        Task<IEnumerable<ShowDto>> GetShows();
        Task<ShowDto> GetShow(int id);
        Task<TicketDto> GetOption(int id);
       
    }
}