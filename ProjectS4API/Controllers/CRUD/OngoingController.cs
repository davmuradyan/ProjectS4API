using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.OngoingEvalServices;

namespace ProjectS4API.Controllers.CRUD
{
    [ApiController]
    [Route("[controller]")]
    public class OngoingEvalController : ControllerBase
    {
        private readonly IOngoingEvalCRUDService ongoingEvalService;

        public OngoingEvalController(IOngoingEvalCRUDService ongoingEvalService)
        {
            this.ongoingEvalService = ongoingEvalService;
        }

        [HttpPost("CreateOngoingEval")]
        public async Task<IActionResult> CreateOngoingEval([FromBody] CreateOngoingEvalDto dto)
        {
            var result = await ongoingEvalService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetOngoingEval")]
        public async Task<IActionResult> GetOngoingEval([FromQuery] int id)
        {
            var result = await ongoingEvalService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllOngoingEvals")]
        public async Task<IActionResult> GetAllOngoingEvals()
        {
            var result = await ongoingEvalService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateOngoingEval")]
        public async Task<IActionResult> UpdateOngoingEval([FromBody] UpdateOngoingEvalDto dto)
        {
            var result = await ongoingEvalService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteOngoingEval")]
        public async Task<IActionResult> DeleteOngoingEval([FromQuery] int id)
        {
            var result = await ongoingEvalService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
