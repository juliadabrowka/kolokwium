using kolokwium_apbd.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Repositories;

public interface IPaymentRepository
{
    Task<Payment> GetClientPaymentInfo(int idClient, int subId, Payment payment);
}

public class PaymentRepository : IPaymentRepository
{
    private readonly Context.Context _context = new Context.Context();

    public async Task<Payment> GetClientPaymentInfo(int idClient, int subId, Payment payment)
    {
        try
        {
            return await _context.Payment.SingleAsync(p =>
               p.IdPayment == payment.IdPayment && p.IdClient == idClient && p.IdSubscription == subId);
        }
        catch
        {
            throw new InvalidOperationException($"Subscription is {idClient} is not found");
        }
    }
}