using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.CourseServices
{
    public class CourseCRUDService : ICourseCRUDService
    {
        private readonly MainDbContext db;

        public CourseCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<CourseEntity> Create(CreateCourseDto dto)
        {
            var course = new CourseEntity
            {
                CourseName = dto.CourseName,
                Degree = dto.Degree,
                Qualification = dto.Qualification,
                ProfessorId = dto.ProfessorId,
                DoHId = dto.DoHId,
                AcademicYear = dto.AcademicYear,
                EvaluationId = dto.EvaluationId,
                ToolsDescription = dto.ToolsDescription,
                ResourcesId = dto.ResourcesId,
                Year = dto.Year
            };

            db.Courses.Add(course);
            await db.SaveChangesAsync();
            return course;
        }

        public async Task<CourseEntity?> Read(int id)
        {
            return await db.Courses
                .Include(c => c.Professor)
                .Include(c => c.DoH)
                .Include(c => c.Evaluation)
                .Include(c => c.Resources)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<ICollection<CourseEntity>> ReadAll()
        {
            return await db.Courses
                .Include(c => c.Professor)
                .Include(c => c.DoH)
                .Include(c => c.Evaluation)
                .Include(c => c.Resources)
                .ToListAsync();
        }

        public async Task<CourseEntity?> Update(UpdateCourseDto dto)
        {
            var course = await db.Courses.FindAsync(dto.Id);
            if (course == null) return null;

            course.CourseName = dto.CourseName;
            course.Degree = dto.Degree;
            course.Qualification = dto.Qualification;
            course.ProfessorId = dto.ProfessorId;
            course.DoHId = dto.DoHId;
            course.AcademicYear = dto.AcademicYear;
            course.EvaluationId = dto.EvaluationId;
            course.ToolsDescription = dto.ToolsDescription;
            course.ResourcesId = dto.ResourcesId;
            course.Year = dto.Year;

            await db.SaveChangesAsync();
            return course;
        }

        public async Task<CourseEntity?> Delete(int id)
        {
            var course = await db.Courses.FindAsync(id);
            if (course == null) return null;

            db.Courses.Remove(course);
            await db.SaveChangesAsync();
            return course;
        }
    }
}
