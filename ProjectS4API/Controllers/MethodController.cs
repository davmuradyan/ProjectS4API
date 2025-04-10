using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.MethodServices;

namespace ProjectS4API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MethodController : ControllerBase
    {
        private readonly IMethodCRUDService methodService;

        public MethodController(IMethodCRUDService methodService)
        {
            this.methodService = methodService;
        }

        [HttpPost("CreateMethod")]
        public async Task<IActionResult> CreateMethod([FromBody] CreateMethodDto dto)
        {
            var result = await methodService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetMethod")]
        public async Task<IActionResult> GetMethod([FromQuery] int id)
        {
            var result = await methodService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllMethods")]
        public async Task<IActionResult> GetAllMethods()
        {
            var result = await methodService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateMethod")]
        public async Task<IActionResult> UpdateMethod([FromBody] UpdateMethodDto dto)
        {
            var result = await methodService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteMethod")]
        public async Task<IActionResult> DeleteMethod([FromQuery] int id)
        {
            var result = await methodService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
