namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttrCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proposta", "ClienteId", c => c.Int());
            CreateIndex("dbo.Proposta", "ClienteId");
            AddForeignKey("dbo.Proposta", "ClienteId", "dbo.Cliente", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proposta", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Proposta", new[] { "ClienteId" });
            DropColumn("dbo.Proposta", "ClienteId");
        }
    }
}
