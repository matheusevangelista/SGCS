namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionaEntidadeSeguradora : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seguradora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Seguradora");
        }
    }
}
