using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.EvaluationServices;

namespace ProjectS4API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class EvaluationController : ControllerBase {
        private readonly IEvaluationCRUDService evaluationService;

        public EvaluationController(IEvaluationCRUDService evaluationService) {
            this.evaluationService = evaluationService;
        }

        [HttpPost("CreateEvaluation")]
        public async Task<IActionResult> CreateEvaluation([FromBody] CreateEvaluationDto dto) {
            var result = await evaluationService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetEvaluation")]
        public async Task<IActionResult> GetEvaluation([FromQuery] int id) {
            var result = await evaluationService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllEvaluations")]
        public async Task<IActionResult> GetAllEvaluations() {
            var result = await evaluationService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateEvaluation")]
        public async Task<IActionResult> UpdateEvaluation([FromBody] UpdateEvaluationDto dto) {
            var result = await evaluationService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteEvaluation")]
        public async Task<IActionResult> DeleteEvaluation([FromQuery] int id) {
            var result = await evaluationService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}