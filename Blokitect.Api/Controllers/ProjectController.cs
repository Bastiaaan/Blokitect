using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blokitect.Data.Framework;
using Blokitect.Data.Services;
using Blokitect.Data.Models;
using Blokitect.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blokitect.Api.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ProjectService ProjectService;

        public ProjectController(ProjectService projectService)
        {
            this.ProjectService = projectService;
        }

        [HttpGet]
        [Route("/{userId}")]
        [ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        public ActionResult<IList<ProjectViewModel>> Index()
        {
            try
            {
                return this.Ok(this.ProjectService.ReadAll());
            }
            catch(ServiceOperationException ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("/test")]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        public ActionResult<string> Test()
        {
            return this.Ok("Deze foutmelding klopt gwn niet...");
        }

        [HttpGet]
        [Route("/{userId}/{id}")]
        [ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        [ProducesErrorResponseType(typeof(ServiceOperationException))]
        public async Task<ActionResult<ProjectViewModel>> ReadById(long id)
        {
            try
            {
                return this.Ok();
            }
            catch(ServiceOperationException ex)
            {
                return this.BadRequest(ex);
            }
        }

        //[HttpGet]
        //[Route("")]
        //[ProducesDefaultResponseType(typeof(ServiceOperationResult))]
        //[ProducesErrorResponseType(typeof(ServiceOperationException))]
    }
}
