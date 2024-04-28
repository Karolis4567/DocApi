using Microsoft.AspNetCore.Mvc;
using PetApi.Dtos;
using PetApi.Init;

namespace PetApi.Controllers
{
    /// <summary>
    /// Controller for pet objects
    /// </summary>

    [ApiController]
    [Route("[controller]/[action]")]
    public class PetController : Controller
    {
        /// <summary>
        /// Retrieve all objects
        /// </summary>
        /// <remarks>Retreive information about all registred pets</remarks>
        /// <response code="200">Success</response>
        /// <response code="500">Problems with database</response>
        [HttpGet]
        public IActionResult GetPets()
        {
            var ret = InitClass.Init<PetDto>(5);
            return Ok(ret);
        }


        /// <summary>
        /// Retrieve one object
        /// </summary>
        /// <remarks>Retreive information about one pet</remarks>
        /// <response code="200">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>

        [HttpGet]
        public IActionResult GetPet(int[] id)
        {
            var ret = InitClass.Init<PetDto>(1);
            return Ok(ret[0]);
        }

        /// <summary>
        /// Create object
        /// </summary>
        /// <remarks>Create registrated pet</remarks>
        /// <response code="201">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>
        [HttpPost]
        public IActionResult CreatePet([FromBody] PetDto pet)
        {
            return StatusCode(201);
        }

        /// <summary>
        /// Update object
        /// </summary>
        /// <remarks>Update registrated pet information</remarks>
        /// <response code="201">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>
        [HttpPut]
        public IActionResult UpdatePet([FromBody] PetDto pet)
        {
            return StatusCode(200);
        }
        
        /// <summary>
        /// Delete object
        /// </summary>
        /// <remarks>Delete pet information from registry</remarks>
        /// <response code="201">Deleted</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>

        [HttpDelete]
        public IActionResult DeletePet(int[] id)
        {
            var ret = new DeleteDto();
            ret.sucess = true;
            return StatusCode(201, ret);
        }
    }
}
