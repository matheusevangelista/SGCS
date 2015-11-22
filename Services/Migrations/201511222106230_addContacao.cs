namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addContacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proposta", "ValorCotacao", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proposta", "ValorCotacao");
        }
    }
}
