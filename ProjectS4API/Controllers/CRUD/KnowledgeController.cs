using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.KnowledgeServices;

namespace ProjectS4API.Controllers.CRUD
{
    [ApiController]
    [Route("[controller]")]
    public class KnowledgeController : ControllerBase
    {
        private readonly IKnowledgeCRUDService knowledgeService;

        public KnowledgeController(IKnowledgeCRUDService knowledgeService)
        {
            this.knowledgeService = knowledgeService;
        }

        [HttpPost("CreateKnowledge")]
        public async Task<IActionResult> CreateKnowledge([FromBody] CreateKnowledgeDto dto)
        {
            var result = await knowledgeService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetKnowledge")]
        public async Task<IActionResult> GetKnowledge([FromQuery] int id)
        {
            var result = await knowledgeService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllKnowledge")]
        public async Task<IActionResult> GetAllKnowledge()
        {
            var result = await knowledgeService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateKnowledge")]
        public async Task<IActionResult> UpdateKnowledge([FromBody] UpdateKnowledgeDto dto)
        {
            var result = await knowledgeService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteKnowledge")]
        public async Task<IActionResult> DeleteKnowledge([FromQuery] int id)
        {
            var result = await knowledgeService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
