using kolokwium_apbd.DTOs;
using kolokwium_apbd.Models;
using kolokwium_apbd.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium_apbd.Controllers;

[Route("/api/client"), ApiController]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService = new ClientService();

    [HttpGet("{idClient:int}")]
    public async Task<Client> GetClientInfo(int clientId)
    {

        var client = await _clientService.GetClient(clientId);
        var result = new ClientDto()
        {
            FirstName = client.FirstName,
            LastName = client.LastName,
            Email = client.Email,
            Telephone = client.Telephone,
        };

        return client;
    }
}