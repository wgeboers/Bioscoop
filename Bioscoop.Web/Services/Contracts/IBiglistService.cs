using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface IBiglistService
    {
        Task<IEnumerable<MovieDto>> GetMovies();
        
    }
}
