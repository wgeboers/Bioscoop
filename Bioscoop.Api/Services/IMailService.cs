using Bioscoop.Api.Models;

namespace Bioscoop.Api.Services
{
    public interface IMailService
    {
        Task<bool> SendAsync(MailData mailData, CancellationToken ct);
    }
}
