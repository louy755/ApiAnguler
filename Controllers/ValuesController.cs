﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAnguler.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
          public HttpRequestMessage Get()
        {
            var retVal = (key1: "Value1", key2: "Value2");
            return Request.CreateResponse(HttpStatusCode.OK, retVal);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
