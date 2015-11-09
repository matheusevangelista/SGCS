namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidadeVeiculos1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculo", "Modelo", c => c.String());
            AddColumn("dbo.Veiculo", "Cor", c => c.String());
            AddColumn("dbo.Veiculo", "Placa", c => c.String());
            AddColumn("dbo.Veiculo", "Combustivel", c => c.String());
            AddColumn("dbo.Veiculo", "Tipo", c => c.String());
            AddColumn("dbo.Veiculo", "Renavam", c => c.String());
            AddColumn("dbo.Veiculo", "Chassis", c => c.String());
            DropColumn("dbo.Veiculo", "Nome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Veiculo", "Nome", c => c.String());
            DropColumn("dbo.Veiculo", "Chassis");
            DropColumn("dbo.Veiculo", "Renavam");
            DropColumn("dbo.Veiculo", "Tipo");
            DropColumn("dbo.Veiculo", "Combustivel");
            DropColumn("dbo.Veiculo", "Placa");
            DropColumn("dbo.Veiculo", "Cor");
            DropColumn("dbo.Veiculo", "Modelo");
        }
    }
}
