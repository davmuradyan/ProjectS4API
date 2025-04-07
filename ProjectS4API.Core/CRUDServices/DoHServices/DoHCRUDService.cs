using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.DoHServices
{
    public class DoHCRUDService : IDoHCRUDService
    {
        private readonly MainDbContext db;

        public DoHCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<DoHEntity> Create(CreateDoHDto dto)
        {
            var entity = new DoHEntity
            {
                CM = dto.CM,
                TP = dto.TP,
                TPS = dto.TPS,
                ECT = dto.ECT
            };

            db.Distribution_of_Hours.Add(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<DoHEntity?> Read(int id)
        {
            return await db.Distribution_of_Hours.FindAsync(id);
        }

        public async Task<ICollection<DoHEntity>> ReadAll()
        {
            return await db.Distribution_of_Hours.ToListAsync();
        }

        public async Task<DoHEntity?> Update(UpdateDoHDto dto)
        {
            var entity = await db.Distribution_of_Hours.FindAsync(dto.Id);
            if (entity == null) return null;

            entity.CM = dto.CM;
            entity.TP = dto.TP;
            entity.TPS = dto.TPS;
            entity.ECT = dto.ECT;

            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<DoHEntity?> Delete(int id)
        {
            var entity = await db.Distribution_of_Hours.FindAsync(id);
            if (entity == null) return null;

            db.Distribution_of_Hours.Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }
    }
}
