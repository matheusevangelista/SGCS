namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAttrFilial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apolice", "FilialId", c => c.Int(nullable: false));
            CreateIndex("dbo.Apolice", "FilialId");
            AddForeignKey("dbo.Apolice", "FilialId", "dbo.Filial", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Apolice", "FilialId", "dbo.Filial");
            DropIndex("dbo.Apolice", new[] { "FilialId" });
            DropColumn("dbo.Apolice", "FilialId");
        }
    }
}
