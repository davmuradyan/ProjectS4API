using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.MethodServices
{
    public class MethodCRUDService : IMethodCRUDService
    {
        private readonly MainDbContext db;

        public MethodCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<MethodEntity> Create(CreateMethodDto dto)
        {
            var entity = new MethodEntity
            {
                Method = dto.Method
            };

            db.Methods.Add(entity);
            await db.SaveChangesAsync();

            return entity;
        }

        public async Task<MethodEntity?> Read(int id)
        {
            return await db.Methods.FindAsync(id);
        }

        public async Task<ICollection<MethodEntity>> ReadAll()
        {
            return await db.Methods.ToListAsync();
        }

        public async Task<MethodEntity?> Update(UpdateMethodDto dto)
        {
            var entity = await db.Methods.FindAsync(dto.Id);
            if (entity == null) return null;

            entity.Method = dto.Method;
            await db.SaveChangesAsync();

            return entity;
        }

        public async Task<MethodEntity?> Delete(int id)
        {
            var entity = await db.Methods.FindAsync(id);
            if (entity == null) return null;

            db.Methods.Remove(entity);
            await db.SaveChangesAsync();

            return entity;
        }
    }
}
