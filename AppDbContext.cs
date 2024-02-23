using Microsoft.EntityFrameworkCore;

namespace DockerCalculator;

public class AppDbContext : DbContext
{
    public DbSet<CalculationLog> CalculationLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            Utilities.GetConnectionString(), 
            ServerVersion.AutoDetect(Utilities.GetConnectionString())
            );
    }
}

