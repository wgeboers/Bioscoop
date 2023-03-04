using Blazored.LocalStorage;
using Bioscoop.Models.Dtos;
using Bioscoop.Web.Services.Contracts;

namespace Bioscoop.Web.Services
{
    public class ManageTicketsLocalStorageService : IManageTicketsLocalStorageService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly ITicketService ticketService;

        private const string key = "Most sold show";

        public ManageTicketsLocalStorageService(ILocalStorageService localStorageService,
                                                 ITicketService ticketService)
        {
            this.localStorageService = localStorageService;
            this.ticketService = ticketService;
        }

        public async Task<IEnumerable<TicketDto>> GetCollection()
        {
            return await this.localStorageService.GetItemAsync<IEnumerable<TicketDto>>(key)
                    ?? await AddCollection();
        }

        public async Task RemoveCollection()
        {
            await this.localStorageService.RemoveItemAsync(key);
        }

        private async Task<IEnumerable<TicketDto>> AddCollection()
        {
            var ticketCollection = await this.ticketService.GetItems();

            if (ticketCollection != null)
            {
                await this.localStorageService.SetItemAsync(key, ticketCollection);
            }

            return ticketCollection;

        }

    }
}
