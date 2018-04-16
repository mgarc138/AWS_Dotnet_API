using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AWSServerless1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Value> Get()
        {
            return new Value[] {new Value {Id = 1, TextContent = "marlon"}, new Value {Id = 2, TextContent = "Adrina"}};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Value Get(int id)
        {
            return new Value { Id = id, TextContent = "marlon"};
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Value value)
        {
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new {id = value.Id}, value);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Value 
    {
        public int Id { get; set; }
        [Required]
        public string TextContent { get; set; }

    }


}
