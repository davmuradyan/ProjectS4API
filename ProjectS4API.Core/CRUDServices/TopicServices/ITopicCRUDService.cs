using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.TopicServices {
    public interface ITopicCRUDService {
        public Task<TopicEntity> Create(CreateTopicDto dto);
        public Task<TopicEntity?> Read(int id);
        public Task<ICollection<TopicEntity>> ReadAll();
        public Task<TopicEntity?> Update(UpdateTopicDto dto);
        public Task<TopicEntity?> Delete(int id);
    }
}