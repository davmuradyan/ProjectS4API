using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.ResourcesServices {
    public interface IResourcesCRUDService {
        Task<ResourcesEntity> Create(CreateResourcesDto dto);
        Task<ResourcesEntity?> Read(int id);
        Task<ICollection<ResourcesEntity>> ReadAll();
        Task<ResourcesEntity?> Update(UpdateResourcesDto dto);
        Task<ResourcesEntity?> Delete(int id);
    }
}