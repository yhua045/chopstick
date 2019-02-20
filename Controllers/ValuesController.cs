using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chopstick.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chopstick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
      private readonly NorthWndContext dbContext;
      public ValuesController(NorthWndContext dbContext){
        this.dbContext = dbContext;
      }
        // GET api/values
        [HttpGet]
        public ActionResult<List<Categories>> Get()
        {
            return dbContext.Categories.ToList();
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
