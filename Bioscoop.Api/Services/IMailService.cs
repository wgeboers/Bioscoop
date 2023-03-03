using Bioscoop.Models.Models;

namespace Bioscoop.Api.Services
{
    public interface IMailService
    {
        Task<bool> SendAsync(MailData mailData, CancellationToken ct);
        Task<bool> SendWithAttachmentsAsync(MailDataWithAttachments mailData, CancellationToken ct);
        Task<bool> SendWithAttachmentByteAsync(MailDataWithAttachmentByte mailData, CancellationToken ct);
    }
}
