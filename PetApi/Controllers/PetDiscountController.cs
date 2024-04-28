using Microsoft.AspNetCore.Mvc;
using PetApi.Dtos;
using PetApi.Init;

namespace PetApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PetDiscountController : Controller
    {
        /// <summary>
        /// Retrieve one object
        /// </summary>
        /// <remarks>Get discount information related to pet</remarks>
        /// <response code="200">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>
        [HttpGet]
        public IActionResult GetPetDiscount(int petId)
        {
            var ret = InitClass.Init<PetDiscountDto>(1);
            return Ok(ret[0]);
        }

        /// <summary>
        /// Adds object
        /// </summary>
        /// <remarks>Adds pet dicount information</remarks>
        /// <response code="201">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>
        [HttpPost]
        public IActionResult AddPetDiscount(PetDiscountDto discount)
        {
            return StatusCode(201);
        }

        /// <summary>
        /// Updates object
        /// </summary>
        /// <remarks>Updates pet dicount information</remarks>
        /// <response code="201">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>

        [HttpPut]
        public IActionResult UpdatePetDiscount(int petId)
        {
            return StatusCode(201);
        }

        /// <summary>
        /// Deletes object
        /// </summary>
        /// <remarks>Deletes pet dicount information</remarks>
        /// <response code="201">Success</response>
        /// <response code="400">Incorrect parameters</response>
        /// <response code="500">Problems with database</response>
        [HttpDelete]
        public IActionResult DeletePetDiscount(int petId)
        {
            return StatusCode(201);
        }
    }
}
