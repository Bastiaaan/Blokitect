using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blokitect.Data.Services;

namespace Blokitect.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        //private readonly CustomerService CustomerService;

        public CustomerController()
        {

        }

        [HttpGet]
        [ProducesResponseType(typeof(ActionResult<string>), 200)]
        public ActionResult<string> Index()
        {
            return this.Ok("Customer.Index() method works");
        }



        [HttpGet]
        [Route("id")]
        [ProducesResponseType(typeof(ActionResult<string>), 200)]
        public ActionResult<string> Id()
        {
            return this.Ok("Customer.Id() method works");
        }

    }
}
