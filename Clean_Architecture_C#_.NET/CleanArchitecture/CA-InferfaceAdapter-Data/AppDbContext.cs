using Microsoft.EntityFrameworkCore;

namespace CA_InferfaceAdapter_Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}
