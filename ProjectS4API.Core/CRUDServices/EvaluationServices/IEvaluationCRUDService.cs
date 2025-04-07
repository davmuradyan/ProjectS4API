using ProjectS4API.Data.Entities;

public interface IEvaluationCRUDService
{
    public Task<EvaluationEntity> Create(CreateEvaluationDto dto);
    public Task<EvaluationEntity?> Read(int id);
    public Task<ICollection<EvaluationEntity>> ReadAll();
    public Task<EvaluationEntity?> Update(UpdateEvaluationDto dto);
    public Task<EvaluationEntity?> Delete(int id);
}
