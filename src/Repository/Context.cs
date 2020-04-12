using Core;
using Microsoft.EntityFrameworkCore;



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


            modelBuilder.Entity<ListaDeCompras>()
                        .HasMany<Produto>(p => )

        }

    }

}
