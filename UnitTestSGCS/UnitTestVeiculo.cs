using Business.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Web.Mvc;
using UnitTestSGCS.DAL;

namespace UnitTestSGCS
{
    /// <summary>
    /// Summary description for UnitTestVeiculo
    /// </summary>
    [TestClass]
    public class UnitTestaArmazenamentoVeiculo
    {
        private TestDBContext db = new TestDBContext();
        public UnitTestaArmazenamentoVeiculo()
        {
            Veiculo v = new Veiculo();

            v.Id = 1;
            v.Chassis = "765676";
            v.Combustivel = "Gasolina";
            v.Cor = "Azul";
            v.Modelo = "2015";
            v.Placa = "HEA1208";
            v.Renavam = "867hyhd";
            v.Tipo = "Passeio";

            db.veiculo.Add(v);

            Veiculo veiculoFromDB = db.veiculo.Where(id => id.Id == 1).FirstOrDefault();

            Assert.AreEqual(v, veiculoFromDB);

        }
    }
}
