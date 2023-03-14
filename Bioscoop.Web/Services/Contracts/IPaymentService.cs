using Bioscoop.Models.Dtos;

namespace Bioscoop.Web.Services.Contracts
{
    public interface IPaymentService
    {
        Task<PaymentDto> GetPaymentLink(string paymentID);
        Task<PaymentDto> MakePayment(decimal amount, TicketDto ticket);
    }
}
