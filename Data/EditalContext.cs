using Microsoft.EntityFrameworkCore;
using ApredizadoApp.Models;

namespace ApredizadoApp.Data
{
    public class EditalContext: DbContext
    {
        public EditalContext(DbContextOptions<EditalContext> options)
            : base(options)
        {
        }

        public DbSet<Edital> Edital { get; set; }
    }
}
