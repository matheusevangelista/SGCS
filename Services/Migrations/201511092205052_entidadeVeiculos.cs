namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidadeVeiculos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Ano = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veiculo");
        }
    }
}
