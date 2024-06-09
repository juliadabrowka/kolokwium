using kolokwium_apbd.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Repositories;


public interface IClientRepository
{
    Task<Client> GetClient(int idClient);
}

public class ClientRepository : IClientRepository
{
    private readonly Context.Context _context = new Context.Context();
    
    public async Task<Client> GetClient(int idClient)
    {
        try
        {
            return await _context.Client.SingleAsync(client => client.IdClient == idClient);
        }
        catch
        {
            throw new InvalidOperationException($"Client is {idClient} is not found");
        }
    }
}