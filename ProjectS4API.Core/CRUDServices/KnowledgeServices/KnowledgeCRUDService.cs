using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.KnowledgeServices
{
    public class KnowledgeCRUDService : IKnowledgeCRUDService
    {
        private readonly MainDbContext db;

        public KnowledgeCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<KnowledgeEntity> Create(CreateKnowledgeDto dto)
        {
            var entity = new KnowledgeEntity
            {
                Level = dto.Level,
                Description = dto.Description,
                CourseId = dto.CourseId
            };

            db.Knowledge.Add(entity);
            await db.SaveChangesAsync();

            return entity;
        }

        public async Task<KnowledgeEntity?> Read(int id)
        {
            return await db.Knowledge
                .Include(k => k.Course)
                .FirstOrDefaultAsync(k => k.Id == id);
        }

        public async Task<ICollection<KnowledgeEntity>> ReadAll()
        {
            return await db.Knowledge
                .Include(k => k.Course)
                .ToListAsync();
        }

        public async Task<KnowledgeEntity?> Update(UpdateKnowledgeDto dto)
        {
            var entity = await db.Knowledge.FindAsync(dto.Id);
            if (entity == null) return null;

            entity.Level = dto.Level;
            entity.Description = dto.Description;
            entity.CourseId = dto.CourseId;

            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<KnowledgeEntity?> Delete(int id)
        {
            var entity = await db.Knowledge.FindAsync(id);
            if (entity == null) return null;

            db.Knowledge.Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }
    }
}
