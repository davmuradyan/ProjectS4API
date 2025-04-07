using ProjectS4API.Data.Entities;

public interface ICourseCRUDService
{
    public Task<CourseEntity> Create(CreateCourseDto dto);
    public Task<CourseEntity?> Read(int id);
    public Task<ICollection<CourseEntity>> ReadAll();
    public Task<CourseEntity?> Update(UpdateCourseDto dto);
    public Task<CourseEntity?> Delete(int id);
}
