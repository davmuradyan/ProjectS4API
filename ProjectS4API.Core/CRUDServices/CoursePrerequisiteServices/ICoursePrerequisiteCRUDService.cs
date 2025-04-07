using ProjectS4API.Data.Entities;

public interface ICoursePrerequisiteCRUDService
{
    public Task<CoursePrerequisiteEntity> Create(CreateCoursePrerequisiteDto dto);
    public Task<CoursePrerequisiteEntity?> Read(int id);
    public Task<ICollection<CoursePrerequisiteEntity>> ReadAll();
    public Task<CoursePrerequisiteEntity?> Update(UpdateCoursePrerequisiteDto dto);
    public Task<CoursePrerequisiteEntity?> Delete(int id);
}
