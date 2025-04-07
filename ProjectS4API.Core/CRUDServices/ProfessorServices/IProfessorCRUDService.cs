using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.ProfessorServices {
    public interface IProfessorCRUDService {
        public Task<ProfessorEntity> Create(CreateProfessorDto dto);
        public Task<ProfessorEntity?> Read(int id);
        public Task<ICollection<ProfessorEntity>> ReadAll();
        public Task<ProfessorEntity?> Update(UpdateProfessorDto dto);
        public Task<ProfessorEntity?> Delete(int id);
    }
}