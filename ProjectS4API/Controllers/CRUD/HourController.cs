using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.HourServices;

namespace ProjectS4API.Controllers.CRUD
{
    [ApiController]
    [Route("[controller]")]
    public class HourController : ControllerBase
    {
        private readonly IHourCRUDService hourService;

        public HourController(IHourCRUDService hourService)
        {
            this.hourService = hourService;
        }

        [HttpPost("CreateHour")]
        public async Task<IActionResult> CreateHour([FromBody] CreateHourDto dto)
        {
            var result = await hourService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetHour")]
        public async Task<IActionResult> GetHour([FromQuery] int id)
        {
            var result = await hourService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllHours")]
        public async Task<IActionResult> GetAllHours()
        {
            var result = await hourService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateHour")]
        public async Task<IActionResult> UpdateHour([FromBody] UpdateHourDto dto)
        {
            var result = await hourService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteHour")]
        public async Task<IActionResult> DeleteHour([FromQuery] int id)
        {
            var result = await hourService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}