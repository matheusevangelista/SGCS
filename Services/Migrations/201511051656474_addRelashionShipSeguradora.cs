namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelashionShipSeguradora : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apolice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeguradoraId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Seguradora", t => t.SeguradoraId, cascadeDelete: true)
                .Index(t => t.SeguradoraId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Apolice", "SeguradoraId", "dbo.Seguradora");
            DropIndex("dbo.Apolice", new[] { "SeguradoraId" });
            DropTable("dbo.Apolice");
        }
    }
}
