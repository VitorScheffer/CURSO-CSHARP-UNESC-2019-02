namespace Projeto.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Veiculo",
                c => new
                    {
                        VeiculoId = c.Int(nullable: false, identity: true),
                        Cor = c.String(),
                        QuantidadePortas = c.Int(nullable: false),
                        QuantidadeRodas = c.Int(nullable: false),
                        Marca = c.String(),
                        Modelo = c.String(),
                        TamanhoAsa = c.Double(),
                        teste = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.VeiculoId);
            
        }
        
        public override void Down()
        {
            DropTable("public.Veiculo");
        }
    }
}
