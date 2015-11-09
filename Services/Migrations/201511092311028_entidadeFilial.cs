namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidadeFilial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filial",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Rua = c.String(),
                        Numero = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Cep = c.String(),
                        Estado = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Filial");
        }
    }
}
