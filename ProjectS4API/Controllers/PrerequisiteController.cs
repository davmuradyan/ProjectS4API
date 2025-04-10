using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.PrerequisiteServices;

namespace ProjectS4API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrerequisiteController : ControllerBase
    {
        private readonly IPrerequisiteCRUDService prerequisiteService;

        public PrerequisiteController(IPrerequisiteCRUDService prerequisiteService)
        {
            this.prerequisiteService = prerequisiteService;
        }

        [HttpPost("CreatePrerequisite")]
        public async Task<IActionResult> CreatePrerequisite([FromBody] CreatePrerequisiteDto dto)
        {
            var result = await prerequisiteService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetPrerequisite")]
        public async Task<IActionResult> GetPrerequisite([FromQuery] int id)
        {
            var result = await prerequisiteService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllPrerequisites")]
        public async Task<IActionResult> GetAllPrerequisites()
        {
            var result = await prerequisiteService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdatePrerequisite")]
        public async Task<IActionResult> UpdatePrerequisite([FromBody] UpdatePrerequisiteDto dto)
        {
            var result = await prerequisiteService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeletePrerequisite")]
        public async Task<IActionResult> DeletePrerequisite([FromQuery] int id)
        {
            var result = await prerequisiteService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
