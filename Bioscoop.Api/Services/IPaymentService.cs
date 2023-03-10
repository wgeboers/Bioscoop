namespace Bioscoop.Api.Services
{
    public interface IPaymentService
    {
        Task MakePayment(decimal amount);
    }
}
