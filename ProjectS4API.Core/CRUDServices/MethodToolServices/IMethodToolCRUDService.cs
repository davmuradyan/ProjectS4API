using ProjectS4API.Data.Entities;

public interface IMethodToolCRUDService
{
    public Task<MethodToolEntity> Create(CreateMethodToolDto dto);
    public Task<MethodToolEntity?> Read(int id);
    public Task<ICollection<MethodToolEntity>> ReadAll();
    public Task<MethodToolEntity?> Update(UpdateMethodToolDto dto);
    public Task<MethodToolEntity?> Delete(int id);
}   
