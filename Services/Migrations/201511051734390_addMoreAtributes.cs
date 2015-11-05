namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoreAtributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apolice", "ProdutoId", c => c.Int(nullable: false));
            AddColumn("dbo.Apolice", "ClienteId", c => c.Int(nullable: false));
            AddColumn("dbo.Apolice", "Indicacao", c => c.String());
            AddColumn("dbo.Apolice", "SituacaoDaApolice", c => c.Int(nullable: false));
            CreateIndex("dbo.Apolice", "ProdutoId");
            CreateIndex("dbo.Apolice", "ClienteId");
            AddForeignKey("dbo.Apolice", "ClienteId", "dbo.Cliente", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Apolice", "ProdutoId", "dbo.Produto", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Apolice", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Apolice", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Apolice", new[] { "ClienteId" });
            DropIndex("dbo.Apolice", new[] { "ProdutoId" });
            DropColumn("dbo.Apolice", "SituacaoDaApolice");
            DropColumn("dbo.Apolice", "Indicacao");
            DropColumn("dbo.Apolice", "ClienteId");
            DropColumn("dbo.Apolice", "ProdutoId");
        }
    }
}
