using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace ExcelService.Controllers
{
    [Route("api/[controller]")]
    public class ExcelController : Controller
    {
        [HttpGet]
        [Route("version")]
        public String Version()
        {
            using (var excel = new NetOffice.ExcelApi.Application())
            {
                var version = excel.Version;

                excel.Quit();

                return version;
            }
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
