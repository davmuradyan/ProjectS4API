using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.OngoingEvalServices {
    public interface IOngoingEvalCRUDService {
        Task<OngoingEvalEntity> Create(CreateOngoingEvalDto dto);
        Task<OngoingEvalEntity?> Read(int id);
        Task<ICollection<OngoingEvalEntity>> ReadAll();
        Task<OngoingEvalEntity?> Update(UpdateOngoingEvalDto dto);
        Task<OngoingEvalEntity?> Delete(int id);
    }
}