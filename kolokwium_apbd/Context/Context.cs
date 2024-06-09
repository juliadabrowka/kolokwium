using kolokwium_apbd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace kolokwium_apbd.Context;

public partial class Context : DbContext
{
    private const string Schema = "subs";
    public Context(){}
    public Context(DbContextOptions<Context> options): base(options) {}
    
    public virtual DbSet<Client> Client { get; set; }
    public virtual DbSet<Discount> Discount { get; set; }
    public virtual DbSet<Payment> Payment { get; set; }
    public virtual DbSet<Sale> Sale { get; set; }
    public virtual DbSet<Subscription> Subscription { get; set; }
}