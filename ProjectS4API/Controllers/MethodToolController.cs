using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.MethodToolServices;

namespace ProjectS4API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MethodToolController : ControllerBase
    {
        private readonly IMethodToolCRUDService methodToolService;

        public MethodToolController(IMethodToolCRUDService methodToolService)
        {
            this.methodToolService = methodToolService;
        }

        [HttpPost("CreateMethodTool")]
        public async Task<IActionResult> CreateMethodTool([FromBody] CreateMethodToolDto dto)
        {
            var result = await methodToolService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetMethodTool")]
        public async Task<IActionResult> GetMethodTool([FromQuery] int id)
        {
            var result = await methodToolService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllMethodTools")]
        public async Task<IActionResult> GetAllMethodTools()
        {
            var result = await methodToolService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateMethodTool")]
        public async Task<IActionResult> UpdateMethodTool([FromBody] UpdateMethodToolDto dto)
        {
            var result = await methodToolService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteMethodTool")]
        public async Task<IActionResult> DeleteMethodTool([FromQuery] int id)
        {
            var result = await methodToolService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
