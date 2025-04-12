using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.ProfessorServices;

namespace ProjectS4API.Controllers.CRUD
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorCRUDService professorService;

        public ProfessorController(IProfessorCRUDService professorService)
        {
            this.professorService = professorService;
        }

        [HttpPost("CreateProfessor")]
        public async Task<IActionResult> CreateProfessor([FromBody] CreateProfessorDto dto)
        {
            var result = await professorService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetProfessor")]
        public async Task<IActionResult> GetProfessor([FromQuery] int id)
        {
            var result = await professorService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllProfessors")]
        public async Task<IActionResult> GetAllProfessors()
        {
            var result = await professorService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateProfessor")]
        public async Task<IActionResult> UpdateProfessor([FromBody] UpdateProfessorDto dto)
        {
            var result = await professorService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteProfessor")]
        public async Task<IActionResult> DeleteProfessor([FromQuery] int id)
        {
            var result = await professorService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
