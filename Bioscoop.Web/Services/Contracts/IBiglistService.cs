using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface IBiglistService
    {
        Task<IEnumerable<ShowDto>> GetShows();
        Task<ShowDto> GetShow(int id);
        
    }
}
