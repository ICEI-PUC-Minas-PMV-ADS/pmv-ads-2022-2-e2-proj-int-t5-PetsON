using Microsoft.EntityFrameworkCore;
using PetsOn.Domain.Entities;

namespace PetsOn.Repository.DAL
{
    public class ApplicationDbContext : DbContext
    {
       
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ItemOrdemServico> ItemOrdemServicos { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<Petshop> Petshop { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Usuario>().HasKey(x => x.Id);

            builder.Entity<Petshop>().HasKey(x => x.Id);

            builder.Entity<Petshop>().HasMany(x => x.Clientes);

            builder.Entity<Servico>().HasKey(x => x.Id);

            builder.Entity<Cliente>().HasKey(x => x.Id);

            builder.Entity<Cliente>().HasMany(x => x.Animais);

            builder.Entity<Cliente>().HasMany(x => x.OrdemServicos);

            builder.Entity<Animal>().HasKey(x => x.Id);

            builder.Entity<OrdemServico>().HasKey( x => x.Id);

            builder.Entity<ItemOrdemServico>().HasKey(x => new { x.Id_Ordem_Servico, x.Id_Servico });

            //builder.Entity<ItemOrdemServico>()
            //.HasOne(x => x.OrdemServico)
            //.WithMany(y => y.Servicos)
            //.HasForeignKey(x => x.OrdemServico);

        }       

    }
}
