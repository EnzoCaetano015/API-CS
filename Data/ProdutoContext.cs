using Microsoft.EntityFrameworkCore;
using MinhaApiCrud.Models;

namespace MinhaApiCrud.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options)
            : base(options)
        { 
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
