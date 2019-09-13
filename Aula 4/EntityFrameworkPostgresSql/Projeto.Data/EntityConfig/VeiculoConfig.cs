using Projeto.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Data.EntityConfig
{

    public class VeiculoConfig : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoConfig()
        {
            HasKey(p => p.Codigo);

            HasOptional(p => p.Garagem)
                .WithMany()
                .HasForeignKey(p => p.GaragemId);
        }
    }

}