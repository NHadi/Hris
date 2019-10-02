using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hris.Common.Securities;
using Microsoft.AspNetCore.Mvc;
using static Hris.Common.Global;

namespace Hris.Master.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var encrypt = Encryptor.Encrypt("Data Source=.\\;Initial Catalog=Hris;Integrated Security=False;User ID=sa;Password=P@55w0rd;");
            var decrypt = Encryptor.Decrypt(encrypt);
            return new string[] { "value1", "value2", encrypt, decrypt };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
