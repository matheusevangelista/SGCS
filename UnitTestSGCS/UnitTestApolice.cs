using Business.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestSGCS.DAL;

namespace UnitTestSGCS
{
    [TestClass]
    public class UnitTestApolice
    {

        private TestDBContext db = new TestDBContext();

        [TestMethod]
        public void testaArmazenamentoApolice()
        {
            Apolice a = new Apolice();

            Produto produto = new Produto();
            produto.Id = 1;
            produto.Nome = "Veículos";
            Seguradora seguradora = new Seguradora();
            seguradora.Nome = "Porto Seguro";
            Cliente cliente = new Cliente();
            cliente.Nome = "José";
            Filial filial = new Filial();
            filial.Nome = "Contagem";
            Proposta proposta = new Proposta();
            a.Produto = produto;
            a.Seguradora = seguradora;
            a.Cliente = cliente;
            a.Filial = filial;
            a.Proposta = proposta;
            a.Id = 1;
            a.PropostaId = 7;
            a.SeguradoraId = 2;
            a.ProdutoId = 3;
            a.ClienteId = 2;
            a.Indicacao = "Jose Teste";
            a.FilialId = 3;
            a.SituacaoDaApolice = Apolice.SituacaoApolice.ATIVA;

            db.apolice.Add(a);

            Apolice apoliceFromDB = db.apolice.Where(ap => ap.Id == 1).FirstOrDefault();

            Assert.AreEqual(a, apoliceFromDB);
        }
    }

}


