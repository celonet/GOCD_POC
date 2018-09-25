using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace GoCD_Poc.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => new string[] { "value1", "value2" };

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) => "value";

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
