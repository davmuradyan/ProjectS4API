using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.ResourcesServices {
    public interface IResourcesCRUDService {
        public Task<ResourcesEntity> Create(CreateResourcesDto dto);
        public Task<ResourcesEntity?> Read(int id);
        public Task<ICollection<ResourcesEntity>> ReadAll();
        public Task<ResourcesEntity?> Update(UpdateResourcesDto dto);
        public Task<ResourcesEntity?> Delete(int id);
    }
}