using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WhiskyInventory.Business.Codetable;
using WhiskyInventory.Data.Models;

namespace WhiskyInventory.Api.Controllers
{
    [Route("api/[controller]")]
    public class RegionController : Controller
    {
        private readonly ICodetableGetter _codetableGetter;

        public RegionController(ICodetableGetter codetableGetter)
        {
            _codetableGetter = codetableGetter;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Region> Get()
        {
            return _codetableGetter.GetRegions();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
}
