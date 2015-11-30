using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSGCS.DAL;
using Business.Models;

namespace UnitTestSGCS
{
    [TestClass]
    class UnitTestSeguradora
    {
        private TestDBContext db = new TestDBContext();

        [TestMethod]
        public void testaArmazenamentoSeguradora()
        {
            Seguradora s = new Seguradora();


            s.Nome = "Porto Seguro";
            s.Descricao = "Convenio so para seguros de veiculos";

            db.seguradoras.Add(s);



            Seguradora seguradoraFromDB = db.seguradoras.Where(No => No.Nome == s.Nome).FirstOrDefault();

            Assert.AreEqual(s, seguradoraFromDB);




        }

    }
}
