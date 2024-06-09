using kolokwium_apbd.Models;
using kolokwium_apbd.Repositories;

namespace kolokwium_apbd.Services;


public interface IClientService
{
    Task<Client> GetClient(int idClient);
}
public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository = new ClientRepository();

    public async Task<Client> GetClient(int idClient)
    {
        return await _clientRepository.GetClient(idClient);
    }
}