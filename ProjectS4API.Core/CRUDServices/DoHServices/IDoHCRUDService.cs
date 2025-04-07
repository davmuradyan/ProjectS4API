using ProjectS4API.Data.Entities;

public interface IDoHCRUDService
{
    Task<DoHEntity> Create(CreateDoHDto dto);
    Task<DoHEntity?> Read(int id);
    Task<ICollection<DoHEntity>> ReadAll();
    Task<DoHEntity?> Update(UpdateDoHDto dto);
    Task<DoHEntity?> Delete(int id);
}
