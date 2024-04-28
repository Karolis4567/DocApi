using Microsoft.AspNetCore.Mvc;
using PetApi.Dtos;
using PetApi.Init;
using System.Diagnostics.Eventing.Reader;

namespace PetApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PetTypeController : Controller
    {
        /// <summary>
        /// Gets array of objects
        /// </summary>
        /// <remarks>Gets all pet types</remarks>
        /// <response code="200">Success</response>
        /// <response code="500">Problems with database</response>

        [HttpGet]
        public IActionResult GetTypes()
        {
            var ret = InitClass.Init<PetTypeDto>(5);
            return Ok(ret);
        }

        /// <summary>
        /// Gets array of objects
        /// </summary>
        /// <remarks>Gets all pet type groups</remarks>
        /// <response code="200">Success</response>
        /// <response code="500">Problems with database</response>
        [HttpGet]
        public IActionResult PetTypesGroups()
        {
            var ret = InitClass.Init<PetTypeGroupDto>(5);
            return Ok(ret);
        }
    }
}
