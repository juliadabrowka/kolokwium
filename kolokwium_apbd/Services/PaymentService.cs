using kolokwium_apbd.Models;
using kolokwium_apbd.Repositories;

namespace kolokwium_apbd.Services;

public interface IPaymentService
{
    Task<Payment> GetClientPaymentInfo(int idClient, int subId, Payment payment);
}
public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _paymentRepository = new PaymentRepository();

    public async Task<Payment> GetClientPaymentInfo(int idClient, int subId, Payment payment)
    {
        return await _paymentRepository.GetClientPaymentInfo(idClient, subId, payment);
    }
}