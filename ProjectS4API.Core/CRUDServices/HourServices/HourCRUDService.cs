using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.HourServices
{
    public class HourCRUDService : IHourCRUDService
    {
        private readonly MainDbContext db;

        public HourCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<HourEntity> Create(CreateHourDto dto)
        {
            var entity = new HourEntity
            {
                CM = dto.CM,
                TD = dto.TD
            };

            db.Hours.Add(entity);
            await db.SaveChangesAsync();

            return entity;
        }

        public async Task<HourEntity?> Read(int id)
        {
            return await db.Hours.FindAsync(id);
        }

        public async Task<ICollection<HourEntity>> ReadAll()
        {
            return await db.Hours.ToListAsync();
        }

        public async Task<HourEntity?> Update(UpdateHourDto dto)
        {
            var entity = await db.Hours.FindAsync(dto.Id);
            if (entity == null) return null;

            entity.CM = dto.CM;
            entity.TD = dto.TD;

            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<HourEntity?> Delete(int id)
        {
            var entity = await db.Hours.FindAsync(id);
            if (entity == null) return null;

            db.Hours.Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }
    }
}
