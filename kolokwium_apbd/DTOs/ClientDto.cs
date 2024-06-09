namespace kolokwium_apbd.DTOs;

public class ClientDto
{
    private int IdClient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; } = null;
}