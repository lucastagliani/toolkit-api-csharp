using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using toolkit_api_csharp.Model;

namespace toolkit_api_csharp.Controller
{
    public class ClientController : ApiController
    {
        // TODO: what should be the return type here?
        public Object Get()
        {
            return new
            {
                results = new List<SimpleJson>()
                {
                    new SimpleJson { id = 1, value = "ABC", info = "ABC" },
                    new SimpleJson { id = 2, value = "JKL", info = "JKL" }
                }
            };
        }
    }
}
