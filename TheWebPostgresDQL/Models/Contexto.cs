using Microsoft.EntityFrameworkCore;

namespace TheWebPostgresSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
