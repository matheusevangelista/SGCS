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

        // POST: api/Cotacao
        public void Post([FromBody]string value)
        {
            //criar logica para gerar cotação de proposta
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
