using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.ExamServices;

namespace ProjectS4API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ExamController : ControllerBase {
        private readonly IExamCRUDService examService;

        public ExamController(IExamCRUDService examService) {
            this.examService = examService;
        }

        [HttpPost("CreateExam")]
        public async Task<IActionResult> CreateExam([FromBody] CreateExamDto dto) {
            var result = await examService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetExam")]
        public async Task<IActionResult> GetExam([FromQuery] int id) {
            var result = await examService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllExams")]
        public async Task<IActionResult> GetAllExams() {
            var result = await examService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateExam")]
        public async Task<IActionResult> UpdateExam([FromBody] UpdateExamDto dto) {
            var result = await examService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteExam")]
        public async Task<IActionResult> DeleteExam([FromQuery] int id) {
            var result = await examService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}