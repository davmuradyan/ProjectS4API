using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.PrerequisiteServices {
    public interface IPrerequisiteCRUDService {
        public Task<PrerequisiteEntity> Create(CreatePrerequisiteDto dto);
        public Task<PrerequisiteEntity?> Read(int id);
        public Task<ICollection<PrerequisiteEntity>> ReadAll();
        public Task<PrerequisiteEntity?> Update(UpdatePrerequisiteDto dto);
        public Task<PrerequisiteEntity?> Delete(int id);
    }
}
