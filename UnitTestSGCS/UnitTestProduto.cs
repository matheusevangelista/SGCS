using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using UnitTestSGCS.DAL;

namespace UnitTestSGCS
{
    [TestClass]
    public class UnitTestProduto
    {

        private TestDBContext db = new TestDBContext();


        [TestMethod]
        public void TestProduto(){
            Produto p = new Produto();

            p.Id = 1;
            p.Nome = "Veículo";


            db.produto.Add(p);

            Produto produtoFromDB = db.produto.Where(pd => pd.Id == 1).FirstOrDefault();

            Assert.AreEqual(p, produtoFromDB);
        }
    }
}
