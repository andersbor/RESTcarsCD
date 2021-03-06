﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTcarsCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        //private static readonly List<Owner> Data = new List<Owner>() { };
        // GET: api/<OwnersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OwnersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OwnersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OwnersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OwnersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
