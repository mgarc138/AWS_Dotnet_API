using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerless1.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        // GET api/user
        [HttpGet]
        public IEnumerable<string> GetUsers()
        {
            return new string[] { "User1", "User2" };
        }

         // GET api/user/1
        [HttpGet("{id:int}")]
        public string GetUser(int id)
        {
            return $"User1 {id}";
        }

         // POST api/user
        [HttpPost]
        public void PostUser([FromBody]string user)
        {
            // Todo: Implementation
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public void PutUpdateUser(int id, [FromBody]string user)
        {

        }

        
    }



}