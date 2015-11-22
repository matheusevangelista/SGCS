using Business.Models;
using Services.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGCS.Controllers
{
    public class CotacaoController : ApiController
    {
        private SGCSContext db = new SGCSContext();

        // GET: api/Cotacao
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cotacao/5
        public string Get(int id)
        {
            return "value";
        }

        public class CotacaoDTO
        {
            public string ClienteId { get; set; }
            public string Modelo { get; set; }
            public string Ano { get; set; }
            public string Tipo { get; set; }

        }

        // POST: api/Cotacao
        public string Post(CotacaoDTO Cotacao)
        {
            double valor = 1200;

            //criar logica para gerar cotação de proposta
            Cliente cliente = db.Clientes.Find(int.Parse(Cotacao.ClienteId));
            String ano = Cotacao.Ano;

            // Calculando a idade do cliente
            DateTime dataAtual = DateTime.Now;
            DateTime dataNasCli = cliente.DataNascimento;

            TimeSpan dif = dataAtual.Subtract(dataNasCli);

            int idade = dif.Days / 365;

            if (idade < 22)
            {
                valor += 800;
            }
            else if (idade < 26)
            {
                valor += 600;
            }
            else if (idade < 32)
            {
                valor += 500;
            }
            else if (idade < 40)
            {
                valor += 400;
            }
            else if (idade < 50)
            {
                valor += 300;
            }
            else
            {
                valor += 200;
            }

            if (ano == "2016")
            {
                valor += 800;
            }
            else if(ano == "2015")
            {
                valor += 700;
            }
            else if (ano == "2014 ")
            {
                valor += 600;
            }
            else
            {
                valor += 500;
            }


            return ""+valor;
        }

        // PUT: api/Cotacao/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cotacao/5
        public void Delete(int id)
        {
        }
    }
}
