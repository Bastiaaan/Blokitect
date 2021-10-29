using Blokitect.Data.Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blokitect.Api.Controllers
{
    [ApiController]
    [Route("api/")]
    public class HomeController : Controller
    {
        [Route("hello")]
        [HttpGet]
        [ProducesDefaultResponseType(typeof(string))]
        [ProducesErrorResponseType(typeof(Exception))]
        public string Index()
        {
            return "API says hello back";
        }



        [HttpGet]
        [Route("test")]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        public ActionResult<string> Test()
        {
            return this.Ok("Deze foutmelding klopt gwn niet...");
        }
    }
}
