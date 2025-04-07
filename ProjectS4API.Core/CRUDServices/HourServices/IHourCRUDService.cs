using ProjectS4API.Data.Entities;

public interface IHourCRUDService
{
    public Task<HourEntity> Create(CreateHourDto dto);
    public Task<HourEntity?> Read(int id);
    public Task<ICollection<HourEntity>> ReadAll();
    public Task<HourEntity?> Update(UpdateHourDto dto);
    public Task<HourEntity?> Delete(int id);
}
