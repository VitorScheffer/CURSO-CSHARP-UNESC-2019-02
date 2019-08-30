using Projeto.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Projeto.Data.Migrations;

namespace Projeto.Data.Context
{
    [DbConfigurationType(typeof(NpgsqlConfiguration))]
    public class AppDbContext : DbContext
    {
//        public AppDbContext() : base("host=192.168.168.40;port=5432;userid=postgres;password=mysecretpassword;database=teste")
        public AppDbContext() : base("host=localhost;port=5432;userid=postgres;password=mysecretpassword;database=teste")
        {
            Database.SetInitializer<AppDbContext>(null);
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
