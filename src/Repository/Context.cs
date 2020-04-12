using Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;



namespace Repository
{
    public class Context : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Endereco> Enderecos {get; set; }
        public virtual DbSet<Produto> Produtos {get; set; }
        public virtual DbSet<ListaDeCompras> Listas {get; set; }

        public Context(DbContextOptions<Context> options) :
        base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }

}
