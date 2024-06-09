using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium_apbd.Models;

public class Sale
{
    public int IdSale { get; init; }
    [ForeignKey(nameof(Client))]
    public int IdClient { get; init; }
    [ForeignKey(nameof(Subscription))]
    public int IdSubscription { get; init; }
    public DateTime CreatedAt { get; init; }
}