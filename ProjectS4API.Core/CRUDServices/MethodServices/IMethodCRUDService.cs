using ProjectS4API.Data.Entities;

public interface IMethodCRUDService
{
    public Task<MethodEntity> Create(CreateMethodDto dto);
    public Task<MethodEntity?> Read(int id);
    public Task<ICollection<MethodEntity>> ReadAll();
    public Task<MethodEntity?> Update(UpdateMethodDto dto);
    public Task<MethodEntity?> Delete(int id);
}
