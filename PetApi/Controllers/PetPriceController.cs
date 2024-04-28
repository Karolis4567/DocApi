using Microsoft.AspNetCore.Mvc;
using PetApi.Dtos;
using PetApi.Init;

namespace PetApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PetPriceController : Controller
    {

        /// <summary>
        /// Gets one object
        /// </summary>
        /// <remarks>Gets pet discount information</remarks>
        /// <response code="200">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>
        [HttpGet]
        public IActionResult GetPetPrice(int petId)
        {
            var ret = InitClass.Init<PetPriceDto>(1);
            return Ok(ret[0]);
        }

        /// <summary>
        /// Creates object
        /// </summary>
        /// <remarks>Creates pet price object</remarks>
        /// <response code="201">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>

        [HttpPost]
        public IActionResult CreatePetPrice(PetPriceDto petPrice)
        {
            return StatusCode(201);
        }

        /// <summary>
        /// Updates object
        /// </summary>
        /// <remarks>Updates pet price object</remarks>
        /// <response code="201">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>
        [HttpPut]
        public IActionResult UpdatePetPrice(PetPriceDto petPrice)
        {
            return StatusCode(201);
        }
    }
}
