using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.ResourcesServices;

namespace ProjectS4API.Controllers.CRUD
{
    [ApiController]
    [Route("[controller]")]
    public class ResourcesController : ControllerBase
    {
        private readonly IResourcesCRUDService resourcesService;

        public ResourcesController(IResourcesCRUDService resourcesService)
        {
            this.resourcesService = resourcesService;
        }

        [HttpPost("CreateResource")]
        public async Task<IActionResult> CreateResource([FromBody] CreateResourcesDto dto)
        {
            var result = await resourcesService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetResource")]
        public async Task<IActionResult> GetResource([FromQuery] int id)
        {
            var result = await resourcesService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllResources")]
        public async Task<IActionResult> GetAllResources()
        {
            var result = await resourcesService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateResource")]
        public async Task<IActionResult> UpdateResource([FromBody] UpdateResourcesDto dto)
        {
            var result = await resourcesService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteResource")]
        public async Task<IActionResult> DeleteResource([FromQuery] int id)
        {
            var result = await resourcesService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
