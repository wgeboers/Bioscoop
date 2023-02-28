using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface IBiglistService
    {
        Task<IEnumerable<ShowDto>> GetMovies();
        
    }
}
