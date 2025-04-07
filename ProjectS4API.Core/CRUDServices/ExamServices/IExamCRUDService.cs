using ProjectS4API.Data.Entities;

public interface IExamCRUDService
{
    public Task<ExamEntity> Create(CreateExamDto dto);
    public Task<ExamEntity?> Read(int id);
    public Task<ICollection<ExamEntity>> ReadAll();
    public Task<ExamEntity?> Update(UpdateExamDto dto);
    public Task<ExamEntity?> Delete(int id);
}
