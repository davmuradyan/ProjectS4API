using Microsoft.AspNetCore.Mvc;
using ProjectS4API.Core.CRUDServices.TopicServices;

namespace ProjectS4API.Controllers {
    public class TopicController : Controller {
        private ITopicCRUDService topicService;
        public TopicController(ITopicCRUDService topicService) {
            this.topicService = topicService;
        }

        [HttpGet("/CreateTopic")]
        public IActionResult CreateTopic(CreateTopicDto dto) {
            return Ok(topicService.Create(dto));
        }

        [HttpGet("/GetTopic")]

        public IActionResult ReadTopic(int id) {
            return Ok(topicService.Read(id));
        }

        [HttpGet("/GetAllTopics")]
        public IActionResult ReadAllTopics() {
            return Ok(topicService.ReadAll());
        }

        [HttpPut("/UpdateTopic")]
        public IActionResult UpdateTopic(UpdateTopicDto dto) {
            return Ok(topicService.Update(dto));
        }


        [HttpDelete("/DeleteTopic")]
        public IActionResult DeleteTopic(int id) {
            return Ok(topicService.Delete(id));
        }
    }   
}
