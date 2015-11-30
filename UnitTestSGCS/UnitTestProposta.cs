using Business.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Web.Mvc;
using UnitTestSGCS.DAL;
namespace UnitTestSGCS
{
    [TestClass]
    public class UnitTestProposta
    {
        private TestDBContext db = new TestDBContext();        

        [TestMethod]
        public void TestArmazenamentoProposta()
        {
            Proposta p = new Proposta();
            Cliente cliente = new Cliente();
            Veiculo veiculo = new Veiculo();

            p.Id = 1;
            cliente.Id = 1;
            veiculo.Id = 1;

            p.Id = 1;


            db.propostas.Add(p);

            Proposta propostaFromDB = db.propostas.Where(pr => pr.Id == 1).FirstOrDefault();

            Assert.AreEqual(p, propostaFromDB);
        }
    }
}