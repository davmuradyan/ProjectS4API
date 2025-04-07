using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.PrerequisiteServices {
    public interface IPrerequisiteCRUDService {
        Task<PrerequisiteEntity> Create(CreatePrerequisiteDto dto);
        Task<PrerequisiteEntity?> Read(int id);
        Task<ICollection<PrerequisiteEntity>> ReadAll();
        Task<PrerequisiteEntity?> Update(UpdatePrerequisiteDto dto);
        Task<PrerequisiteEntity?> Delete(int id);
    }
}
