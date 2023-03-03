using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace practicaRepaso.Models
{
    public class carrosContext : DbContext
    {
        public carrosContext(DbContextOptions<carrosContext> options) : base(options) 
        {
        
        }

        public DbSet<carros> carros { get; set; }
    }
}
