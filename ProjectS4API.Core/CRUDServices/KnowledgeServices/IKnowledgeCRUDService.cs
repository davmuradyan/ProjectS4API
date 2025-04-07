using ProjectS4API.Data.Entities;

public interface IKnowledgeCRUDService
{
    public Task<KnowledgeEntity> Create(CreateKnowledgeDto dto);
    public Task<KnowledgeEntity?> Read(int id);
    public Task<ICollection<KnowledgeEntity>> ReadAll();
    public Task<KnowledgeEntity?> Update(UpdateKnowledgeDto dto);
    public Task<KnowledgeEntity?> Delete(int id);
}
