using Bioscoop.Models.Models;

namespace Bioscoop.Web.Services.Contracts
{
    public interface IMailService
    {
        Task<String> EmailTicket(MailData mailData);
    }
}
