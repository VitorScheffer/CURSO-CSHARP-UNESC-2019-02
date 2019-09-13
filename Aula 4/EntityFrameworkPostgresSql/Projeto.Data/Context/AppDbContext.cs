using System;
using Projeto.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Projeto.Data.EntityConfig;
using Projeto.Data.Migrations;

namespace Projeto.Data.Context
{
    [DbConfigurationType(typeof(NpgsqlConfiguration))]
    public class AppDbContext : DbContext
    {
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

            modelBuilder.Properties().Where(a => a.Name.Equals("Codigo")).Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new VeiculoConfig());

            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
