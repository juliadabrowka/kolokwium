namespace kolokwium_apbd.DTOs;

public class PaymentDto
{
    public int IdPayment { get; init; }
    public DateTime Date { get; init; }
    public int IdClient { get; init; }
    public int IdSubscription { get; init; }
}