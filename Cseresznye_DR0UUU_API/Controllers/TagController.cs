using Cseresznye_DR0UUU_API.LibraryModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cseresznye_DR0UUU_API.Controllers
{
    
    [Route("api/tag")]
    [ApiController]
    public class TagController : ControllerBase
    {
        LibraryDatabaseContext context = new LibraryDatabaseContext();
        // GET: api/<TagController>
        [HttpGet]
        public IActionResult Get()
        {
            var x = from y in context.Tags
                    select y;

            return Ok(x);
        }

        // GET api/<TagController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var x = from y in context.Tags
                    where y.TagId == id
                    select y;

            if (x!=null)
            {
                return Ok(x);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/<TagController>
        [HttpPost("ujTag/{nev}/{email}/{telefonszam}/{tagsagiszam}")]
        public IActionResult UjTag(string nev, string email, string telefonszam, string tagsagiszam)
        {
            var x = new Tag
            {
                Nev = nev,
                Email = email,
                Telefonszam = telefonszam,
                TagsagiSzam = tagsagiszam,
                TagsagiDatum = DateTime.Now
            };

            context.Tags.Add(x);
            context.SaveChanges();
            return Ok(x);
        }

        // PUT api/<TagController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TagController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var x = (from y in context.Tags
                    where y.TagId == id
                    select y).FirstOrDefault();
            if (x!=null)
            {
                context.Tags.Remove(x);
                context.SaveChanges();
                return Ok(x);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
