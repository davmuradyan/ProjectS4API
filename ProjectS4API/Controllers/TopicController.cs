using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.TopicServices;

namespace ProjectS4API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicController : ControllerBase
    {
        private readonly ITopicCRUDService topicService;

        public TopicController(ITopicCRUDService topicService)
        {
            this.topicService = topicService;
        }

        [HttpPost("CreateTopic")]
        public async Task<IActionResult> CreateTopic([FromBody] CreateTopicDto dto)
        {
            var result = await topicService.Create(dto);
            return Ok(result);
        }

        [HttpGet("GetTopic")]
        public async Task<IActionResult> ReadTopic([FromQuery] int id)
        {
            var result = await topicService.Read(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("GetAllTopics")]
        public async Task<IActionResult> ReadAllTopics()
        {
            var result = await topicService.ReadAll();
            return Ok(result);
        }

        [HttpPut("UpdateTopic")]
        public async Task<IActionResult> UpdateTopic([FromBody] UpdateTopicDto dto)
        {
            var result = await topicService.Update(dto);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpDelete("DeleteTopic")]
        public async Task<IActionResult> DeleteTopic([FromQuery] int id)
        {
            var result = await topicService.Delete(id);
            return result != null ? Ok(result) : NotFound();
        }
    }
}
