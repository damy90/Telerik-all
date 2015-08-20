using BulsAndCows.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BulsAndCows.WebApi.Controllers
{
    public class BaseController : ApiController
    {
        protected IBulsAndCowsData data;

        public BaseController(IBulsAndCowsData data)
        {
            this.data = data;
        }
    }
}
