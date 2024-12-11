using Cseresznye_DR0UUU_API.LibraryModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cseresznye_DR0UUU_API.Controllers
{
    [Route("api/szerzo")]
    [ApiController]
    public class SzerzoController : ControllerBase
    {
        LibraryDatabaseContext context = new LibraryDatabaseContext();
        // GET: api/<SzerzoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SzerzoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var x = from y in context.Szerzos
                    where y.SzerzoId == id
                    select y;

            if (x != null)
            {
                return Ok(x);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/<SzerzoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SzerzoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SzerzoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
