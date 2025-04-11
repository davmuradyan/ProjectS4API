using ProjectS4API.Core.CRUDServices.TopicServices;
using ProjectS4API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectS4API.Core.OtherSerevices {
    public class TopicServices {
        ITopicCRUDService topicService;
        public TopicServices(ITopicCRUDService topicCRUDService) {
            topicService = topicCRUDService;
        }

        public async Task<List<TopicEntity>?> ReadTopics(int courseId) {
            var topics = await topicService.ReadAll();

            if (topics == null) return null;

            foreach (var item in topics)
            {
                if (item.CourseId != courseId) topics.Remove(item);
            }

            return (List<TopicEntity>)topics;
        }
    }
}
