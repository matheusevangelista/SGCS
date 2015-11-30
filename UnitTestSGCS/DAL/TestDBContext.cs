using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSGCS.DAL
{
    class TestDBContext
    {
        public List<Cliente> clientes = new List<Cliente>();
        public List<Filial> filial = new List<Filial>();
        public List<Produto> produto = new List<Produto>();
        public List<Seguradora> seguradoras = new List<Seguradora>();
        public List<Apolice> apolice = new List<Apolice>();
        public List<Veiculo> veiculo = new List<Veiculo>();
        public List<Proposta> propostas = new List<Proposta>();
    }
}
