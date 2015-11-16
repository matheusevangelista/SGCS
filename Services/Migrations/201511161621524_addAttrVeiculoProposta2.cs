namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAttrVeiculoProposta2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Proposta", "VeiculoId", "dbo.Veiculo");
            DropIndex("dbo.Proposta", new[] { "VeiculoId" });
            AlterColumn("dbo.Proposta", "VeiculoId", c => c.Int());
            CreateIndex("dbo.Proposta", "VeiculoId");
            AddForeignKey("dbo.Proposta", "VeiculoId", "dbo.Veiculo", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proposta", "VeiculoId", "dbo.Veiculo");
            DropIndex("dbo.Proposta", new[] { "VeiculoId" });
            AlterColumn("dbo.Proposta", "VeiculoId", c => c.Int(nullable: true));
            CreateIndex("dbo.Proposta", "VeiculoId");
            AddForeignKey("dbo.Proposta", "VeiculoId", "dbo.Veiculo", "Id", cascadeDelete: true);
        }
    }
}
