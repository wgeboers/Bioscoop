using Bioscoop.Models.Dtos;

namespace Bioscoop.Api.Services
{
    public interface IPaymentService
    {
        Task<PaymentDto> MakePayment(decimal amount, TicketDto ticket);
        Task<PaymentDto> GetPaymentInfo(string paymentId);
    }
}
