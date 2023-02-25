using Bioscoop.Api.Data;
using Bioscoop.Api.Entities;
using Bioscoop.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Api.Repositories
{
    public class ShowRepository : IShowRepository
    {
        private readonly BioscoopDbContext bioscoopDbContext;

        public ShowRepository(BioscoopDbContext bioscoopDbContext)
        {
            this.bioscoopDbContext = bioscoopDbContext;
        }

        public async Task<Show> GetShow(int id)
        {
            var show = await bioscoopDbContext.Shows.FindAsync(id);
            return show;
        }

        public async Task<IEnumerable<Show>> GetShows()
        {
            var shows = await bioscoopDbContext.Shows.ToListAsync();
            return shows;
        }
    }
}
