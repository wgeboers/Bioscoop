using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface IMovieService
    {
        Task<IEnumerable<ShowDto>> GetShows();
    }
}
