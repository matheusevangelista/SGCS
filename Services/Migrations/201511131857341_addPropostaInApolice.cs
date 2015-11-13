namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPropostaInApolice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proposta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataInicioVigencia = c.DateTime(nullable: false),
                        DataFimVigencia = c.DateTime(nullable: false),
                        NumeroEndosso = c.Int(nullable: false),
                        DataEmissaoApolice = c.DateTime(nullable: false),
                        DataBaixaProposta = c.DateTime(nullable: false),
                        NumeroPropostaSeguradora = c.Int(nullable: false),
                        Entrada = c.Single(),
                        NumeroPrestacoes = c.Int(),
                        ValorPrestacoes = c.Single(),
                        DataPrimeiroVencimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Apolice", "PropostaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Apolice", "PropostaId");
            AddForeignKey("dbo.Apolice", "PropostaId", "dbo.Proposta", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Apolice", "PropostaId", "dbo.Proposta");
            DropIndex("dbo.Apolice", new[] { "PropostaId" });
            DropColumn("dbo.Apolice", "PropostaId");
            DropTable("dbo.Proposta");
        }
    }
}
