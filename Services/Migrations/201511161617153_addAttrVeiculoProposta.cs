namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAttrVeiculoProposta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proposta", "VeiculoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Proposta", "VeiculoId");
            AddForeignKey("dbo.Proposta", "VeiculoId", "dbo.Veiculo", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proposta", "VeiculoId", "dbo.Veiculo");
            DropIndex("dbo.Proposta", new[] { "VeiculoId" });
            DropColumn("dbo.Proposta", "VeiculoId");
        }
    }
}
