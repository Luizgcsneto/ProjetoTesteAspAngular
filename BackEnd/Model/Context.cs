using Microsoft.EntityFrameworkCore;

namespace BackEnd.Model
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {
            
        }

        public DbSet<Programador> Programadores { get; set; }
    }
}