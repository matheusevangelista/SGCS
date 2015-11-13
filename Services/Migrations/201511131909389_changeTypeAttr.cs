namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTypeAttr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Proposta", "Entrada", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Proposta", "ValorPrestacoes", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proposta", "ValorPrestacoes", c => c.Single());
            AlterColumn("dbo.Proposta", "Entrada", c => c.Single());
        }
    }
}
