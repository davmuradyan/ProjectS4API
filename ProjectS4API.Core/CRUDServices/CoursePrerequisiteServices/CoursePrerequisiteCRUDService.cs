using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.CoursePrerequisiteServices
{
    public class CoursePrerequisiteCRUDService : ICoursePrerequisiteCRUDService
    {
        private readonly MainDbContext db;

        public CoursePrerequisiteCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<CoursePrerequisiteEntity> Create(CreateCoursePrerequisiteDto dto)
        {
            var entity = new CoursePrerequisiteEntity
            {
                CourseId = dto.CourseId,
                PrerequisiteId = dto.Prerequisite
            };

            db.Course_Prerequisites.Add(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<CoursePrerequisiteEntity?> Read(int id)
        {
            return await db.Course_Prerequisites
                .Include(x => x.Course)
                .Include(x => x.PrerequisiteEntity)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<CoursePrerequisiteEntity>> ReadAll()
        {
            return await db.Course_Prerequisites
                .Include(x => x.Course)
                .Include(x => x.PrerequisiteEntity)
                .ToListAsync();
        }

        public async Task<CoursePrerequisiteEntity?> Update(UpdateCoursePrerequisiteDto dto)
        {
            var entity = await db.Course_Prerequisites.FindAsync(dto.Id);
            if (entity == null) return null;

            entity.CourseId = dto.CourseId;
            entity.PrerequisiteId = dto.Prerequisite;

            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<CoursePrerequisiteEntity?> Delete(int id)
        {
            var entity = await db.Course_Prerequisites.FindAsync(id);
            if (entity == null) return null;

            db.Course_Prerequisites.Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }
    }
}
