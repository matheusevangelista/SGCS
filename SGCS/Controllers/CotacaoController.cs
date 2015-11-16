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
            //criar logica para gerar cotação de proposta


            return Cotacao.Modelo;
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
