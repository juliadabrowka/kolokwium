using kolokwium_apbd.Models;
using kolokwium_apbd.Repositories;

namespace kolokwium_apbd.Services;

public interface ISubscriptionService
{
    Task<Subscription> GetSubscriptionInfo(int subId);
}
public class SubscriptionService : ISubscriptionService
{
    private readonly ISubscriptionRepository _subscriptionRepository = new SubscriptionRepository();

    public async Task<Subscription> GetSubscriptionInfo(int subId)
    {
        return await _subscriptionRepository.GetSubscriptionInfo(subId);
    }
}