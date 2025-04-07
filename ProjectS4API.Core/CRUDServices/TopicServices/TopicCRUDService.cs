using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.TopicServices {
    public class TopicCRUDService : ITopicCRUDService {

        private MainDbContext db;
        public TopicCRUDService(MainDbContext mainDb) { 
            db = mainDb;
        }

        public async Task<TopicEntity> Create(CreateTopicDto dto) {
            var topic = new TopicEntity {
                Topic = dto.Topic,
                CoreResources = dto.CoreResources,
                AdditionalResources = dto.AdditionalResources,
                HourId = dto.HourId,
                CourseId = dto.CourseId
            };

            db.Topics.Add(topic);
            await db.SaveChangesAsync();

            return topic;
        }

        public async Task<TopicEntity?> Read(int id) {
            return await db.Topics
                .Include(t => t.Hour) 
                .Include(t => t.Course)
                .FirstOrDefaultAsync(t => t.Id == id); 
        }

        public async Task<ICollection<TopicEntity>> ReadAll() {
            return await db.Topics
                .Include(t => t.Hour)
                .Include(t => t.Course)
                .ToListAsync();
        }

        public async Task<TopicEntity?> Update(UpdateTopicDto dto) {
            var topic = await db.Topics.FindAsync(dto.Id);

            if (topic == null)
                return null;

            topic.Topic = dto.Topic;
            topic.CoreResources = dto.CoreResources;
            topic.AdditionalResources = dto.AdditionalResources;
            topic.HourId = dto.HourId;
            topic.CourseId = dto.CourseId;

            await db.SaveChangesAsync();

            return topic;
        }

        public async Task<TopicEntity?> Delete(int id) {
            var topic = await db.Topics.FindAsync(id);
            if (topic == null)
                return null;

            db.Topics.Remove(topic);
            await db.SaveChangesAsync();

            return topic;
        }
    }
}
