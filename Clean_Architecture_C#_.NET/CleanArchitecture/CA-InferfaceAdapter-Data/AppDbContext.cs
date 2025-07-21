using CA_InterfaceAdapters_Models;
using Microsoft.EntityFrameworkCore;

namespace CA_InferfaceAdapter_Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<BeerModel> Beers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BeerModel>().ToTable("Beer"); //Esto se hace cuando el nombre de la tabla en la DB es diferente
    }
}
