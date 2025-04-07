using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.MethodToolServices
{
    public class MethodToolCRUDService : IMethodToolCRUDService
    {
        private readonly MainDbContext db;

        public MethodToolCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<MethodToolEntity> Create(CreateMethodToolDto dto)
        {
            var entity = new MethodToolEntity
            {
                CourseId = dto.CourseId,
                MethodId = dto.MethodId
            };

            db.Methods_and_Tools.Add(entity);
            await db.SaveChangesAsync();

            return entity;
        }

        public async Task<MethodToolEntity?> Read(int id)
        {
            return await db.Methods_and_Tools
                .Include(mt => mt.Course)
                .Include(mt => mt.Method)
                .FirstOrDefaultAsync(mt => mt.Id == id);
        }

        public async Task<ICollection<MethodToolEntity>> ReadAll()
        {
            return await db.Methods_and_Tools
                .Include(mt => mt.Course)
                .Include(mt => mt.Method)
                .ToListAsync();
        }

        public async Task<MethodToolEntity?> Update(UpdateMethodToolDto dto)
        {
            var entity = await db.Methods_and_Tools.FindAsync(dto.Id);
            if (entity == null) return null;

            entity.CourseId = dto.CourseId;
            entity.MethodId = dto.MethodId;

            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<MethodToolEntity?> Delete(int id)
        {
            var entity = await db.Methods_and_Tools.FindAsync(id);
            if (entity == null) return null;

            db.Methods_and_Tools.Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }
    }
}
