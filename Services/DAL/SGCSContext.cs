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
    }
}
