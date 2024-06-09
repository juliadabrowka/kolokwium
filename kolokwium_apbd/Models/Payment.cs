using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium_apbd.Models;

public class Payment
{
    [Required, Key]
    public int IdPayment { get; init; }
    [Required]
    public DateTime Date { get; init; }
    [ForeignKey(nameof(Client))]
    public int IdClient { get; init; }
    [ForeignKey(nameof(Subscription))]
    public int IdSubscription { get; init; }
}