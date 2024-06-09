using System.ComponentModel.DataAnnotations;

namespace kolokwium_apbd.Models;

public class Subscription
{
    [Key, Required]
    public int IdSubscription { get; init; }
    [Required, MaxLength(100)]
    public string Name { get; init; }
    [Required]
    public int RenewalPeriod { get; init; }
    [Required]
    public DateTime EndTime { get; init; }
    [Required]
    public int Price { get; init; }
}