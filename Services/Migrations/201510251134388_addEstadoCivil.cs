namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEstadoCivil : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "EstadoCivilCliente", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "EstadoCivilCliente");
        }
    }
}
