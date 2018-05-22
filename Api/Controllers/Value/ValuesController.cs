using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Nkolay.Web.Api.Controllers
{
    public class ValuesController : BaseController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "valuSDFSDFSFDSFDFDSe1", "value2" };
        }
        
        public string Get(int id)
        {
            return DateTime.Now.ToString("hh.mm.ss.ffffff");
        }
        
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
