using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        // GET: api/<PersonsController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            List<Person> oPersons = new List<Person>() { 
            new Person(){Id = 1, Name = "Chan"},
            new Person(){Id = 2, Name = "Christian"},
            new Person(){Id = 3, Name = "Calica"}

            };

            return oPersons;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<PersonsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
