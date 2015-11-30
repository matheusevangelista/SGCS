using Business.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Web.Mvc;
using UnitTestSGCS.DAL;


namespace UnitTestSGCS
{
    [TestClass]
    public class UnitTestFilial
    {
        private TestDBContext db = new TestDBContext();

        [TestMethod]
        public void testaArmazenamentoFilial()
        {
            Filial f = new Filial();

            f.Nome = "Filial Contagem";
            f.Id = 1;
            f.Rua = "Sirma";
            f.Numero = "23";
            f.Bairro = "Santa Cruz Industrial";
            f.Cep = "23456-908";
            f.Cidade = "Contagem";
            f.Estado = "Minas Gerais";
            f.Telefone = "(31) 2345-3455";
           

            db.filial.Add(f);

            Filial filialFromDB = db.filial.Where(id => id.Id == 1).FirstOrDefault();

            Assert.AreEqual(f, filialFromDB);

        }

        
    }
}
