using Bioscoop.Api.Entities;

namespace Bioscoop.Api.Repositories.Contracts
{
    public interface IShowRepository
    {
        Task<IEnumerable<Show>> GetShows();
        Task<Show> GetShow(int id);
    }
}
