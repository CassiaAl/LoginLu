using Microsoft.EntityFrameworkCore;
using appBoasVindas.Models;

namespace appBoasVindas.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; } 
        public DbSet<appBoasVindas.Models.Categoria>? Categoria { get; set; }

        public DbSet<ProdutoCategoria> ProdutoCategoria { get; set; }

    }
}
