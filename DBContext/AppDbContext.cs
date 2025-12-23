using Microsoft.EntityFrameworkCore;

//Entity Framework Core version: 9.0.11, pois a versão 10 não suporta .NET 8.0
namespace Gestão_de_metas_e_Performance.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Gestão_de_metas_e_Performance.Models.User> Users { get; set; }
        public DbSet<Gestão_de_metas_e_Performance.Models.Meta> Metas { get; set; }

    }
}
