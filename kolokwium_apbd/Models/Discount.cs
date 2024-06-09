using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium_apbd.Models;

public class Discount
{
    public int IdDiscount { get; init; }
    public int Value { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    
    [ForeignKey(nameof(Client))]
    public int IdClient { get; set; }
}