using Business.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Web.Mvc;
using UnitTestSGCS.DAL;


namespace UnitTestSGCS
{
    [TestClass]
    public class UnitTestCliente
    {
        private TestDBContext db = new TestDBContext();

        [TestMethod]
        public void testaArmazenamentoCliente()
        {
            Cliente c = new Cliente();

            c.Nome = "João da Silva Teste";
            c.CPF = "59566787472";
            c.RG = "MG-15.550.852";
            c.RGOrgaoEmissor = "SSPMG";
            c.RGDataEmissao = new DateTime(1998, 10, 10);
            c.DataNascimento = new DateTime(1989, 6, 8);
            c.Nacionalidade = "Brasileira";
            c.EstadoCivilCliente = Cliente.EstadoCivil.CASADO;
            c.Profissao = "Engenheiro";
            c.Email = "joao.teste@gmail.com";
            c.Telefone = "31 3131 3131";
            c.Logradouro = "Av. Afonso Pena";
            c.Numero = "650";
            c.Bairro = "Funcionários";
            c.Cidade = "Belo Horizonte";
            c.UF = "Minas Gerais";

            db.clientes.Add(c);

            Cliente clienteFromDB = db.clientes.Where(cf => cf.CPF == c.CPF).FirstOrDefault();

            Assert.AreEqual(c, clienteFromDB);

        }

        [TestMethod]
        public void testaValidacaoCPF()
        {
            Cliente c = new Cliente();

            c.CPF = "123.456.789-21";

            Assert.AreNotEqual(true, Utils.Validations.ValidaCPF(c.CPF));
        }
    }
}
