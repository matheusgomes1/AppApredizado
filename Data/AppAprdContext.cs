using Microsoft.EntityFrameworkCore;
using ApredizadoApp.Models;

namespace ApredizadoApp.Data
{
    public class AppAprdContext: DbContext
    {
        public AppAprdContext(DbContextOptions<AppAprdContext> options)
            : base(options)
        {
        }

        public DbSet<Edital> Edital { get; set; }
    }
}
