using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiTest.Controllers
{
    
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "Get: value1";
        }

        // POST api/values
        public string Post()
        {
            return "Post: value1";
        }

        // PUT api/values/5
        public string Put()
        {
            return "Put: value1";
        }

        
    }
}
