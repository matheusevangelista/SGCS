using Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL
{
    public class SGCSContext : DbContext
    {
        public SGCSContext() : base("SGCSContext") { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Seguradora> Seguradoras { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Apolice> Apolices { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Filial> Filiais { get; set; }

        public DbSet<Proposta> Propostas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Apolice>()
            //            .HasRequired(a => a.Seguradora)
            //            .WithMany(s => s.Apolices)
            //            .WillCascadeOnDelete(false);
                        
        }
    }
}
