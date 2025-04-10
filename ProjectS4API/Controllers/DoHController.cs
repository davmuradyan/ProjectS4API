using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.DoHServices;

namespace ProjectS4API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class DoHController : ControllerBase {
        private readonly IDoHCRUDService doHService;

        public DoHController(IDoHCRUDService doHService) {
            this.doHService = doHService;
        }

        [HttpPost("CreateDoH")]
        public async Task<IActionResult> CreateDoH([FromBody] CreateDoHDto dto) {
            var result = await doHService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetDoH")]
        public async Task<IActionResult> GetDoH([FromQuery] int id) {
            var result = await doHService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllDoH")]
        public async Task<IActionResult> GetAllDoH() {
            var result = await doHService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateDoH")]
        public async Task<IActionResult> UpdateDoH([FromBody] UpdateDoHDto dto) {
            var result = await doHService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteDoH")]
        public async Task<IActionResult> DeleteDoH([FromQuery] int id) {
            var result = await doHService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}