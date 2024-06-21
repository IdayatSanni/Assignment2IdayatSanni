using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2IdayatSanni.Controllers
{
    public class HarvestController : ApiController
    {
        [HttpGet]
        [Route("api/J3/Harvest/{r}/{c}")]
        public string Harvest(int r, int c)
        {



            return "hello";
        }
    }
}
