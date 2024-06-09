using kolokwium_apbd.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Repositories;

public interface ISubscriptionRepository
{
    Task<Subscription> GetSubscriptionInfo(int subId);
}
public class SubscriptionRepository : ISubscriptionRepository
{
    private readonly Context.Context _context = new Context.Context();

    public async Task<Subscription> GetSubscriptionInfo(int subId)
    {
        try
        {
            return await _context.Subscription.SingleAsync(sub => sub.IdSubscription == subId);
        }
        catch
        {
            throw new InvalidOperationException($"Subscription is {subId} is not found");
        }
    }
}