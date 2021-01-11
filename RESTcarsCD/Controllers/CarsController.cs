using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTcarsCD.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTcarsCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static int _nextId = 1;
        private static readonly List<Car> Data = new List<Car>
        {
            new Car {Id = _nextId++, Make = "Volvo", Model = "Amazon"},
            new Car {Id = _nextId++, Make="Audi", Model="A4"}
        };

        // GET: api/<CarsController>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return Data;
        }

        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public Car GetById(int id)
        {
            return Data.FirstOrDefault(car => car.Id==id);
        }

        // POST api/<CarsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
