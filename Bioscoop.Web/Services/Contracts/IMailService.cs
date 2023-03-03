using Bioscoop.Models.Models;

namespace Bioscoop.Web.Services.Contracts
{
    public interface IMailService
    {
        Task<string> EmailTicket(MailData mailData);
        void Nothing();
    }
}
