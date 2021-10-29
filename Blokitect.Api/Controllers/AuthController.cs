using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blokitect.Data.Framework;
using Blokitect.Data.Services;
using Blokitect.Data.Models;
using Blokitect.Data.ViewModels;

namespace Blokitect.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService UserService;

        public AuthController(UserService userService)
        {
            this.UserService = userService;
        }

        [HttpGet]
        [ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        [Route("{userGuid}")]
        public ActionResult<ServiceOperationResult> IsAuthenticated(string userGuid)
        {
            try
            {
                var onlineUser = this.HttpContext.User.Identity.IsAuthenticated;
                var authenticated = this.UserService.IsAuthenticated(userGuid);
                return this.Accepted(authenticated);
            }
            catch(ServiceOperationException ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpGet]
        [ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        [Route("login")]
        public ActionResult<ServiceOperationResult> Login()
        {
            try
            {
                return this.Ok("Login.get works");
            }
            catch (ServiceOperationException ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpPost]
        [ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        public ActionResult<ServiceOperationResult> Login(LoginViewModel viewModel)
        {
            try
            {
                return this.Accepted();
            }
            catch (ServiceOperationException ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpGet]
        [ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        [Route("logout")]
        public ActionResult<ServiceOperationResult> Logout()
        {
            try
            {
                return this.Accepted();
            }
            catch (ServiceOperationException ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpGet]
        [ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        [Route("register")]
        public ActionResult<ServiceOperationResult> Register()
        {
            try
            {
                return this.Accepted();
            }
            catch (ServiceOperationException ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("register")]
        [ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        public async Task<ActionResult<ServiceOperationResult>> Register([FromBody]RegisterViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ServiceOperationResult result = await this.UserService.RegisterCustomer(viewModel);
                    return this.Accepted();
                }

                return this.BadRequest(ModelState);
            }
            catch (ServiceOperationException ex)
            {
                return this.BadRequest(ex);
            }
        }
    }
}
