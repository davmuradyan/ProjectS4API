using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.ProfessorServices {
    public interface IProfessorCRUDService {
        Task<ProfessorEntity> Create(CreateProfessorDto dto);
        Task<ProfessorEntity?> Read(int id);
        Task<ICollection<ProfessorEntity>> ReadAll();
        Task<ProfessorEntity?> Update(UpdateProfessorDto dto);
        Task<ProfessorEntity?> Delete(int id);
    }
}