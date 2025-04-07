using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.PrerequisiteServices {
    public class PrerequisiteCRUDService : IPrerequisiteCRUDService {
        private readonly MainDbContext db;

        public PrerequisiteCRUDService(MainDbContext mainDb) {
            db = mainDb;
        }

        public async Task<PrerequisiteEntity> Create(CreatePrerequisiteDto dto) {
            var prerequisite = new PrerequisiteEntity {
                Prerequisite = dto.Prerequisite
            };

            db.Prerequisites.Add(prerequisite);
            await db.SaveChangesAsync();

            return prerequisite;
        }

        public async Task<PrerequisiteEntity?> Read(int id) {
            return await db.Prerequisites.FindAsync(id);
        }

        public async Task<ICollection<PrerequisiteEntity>> ReadAll() {
            return await db.Prerequisites.ToListAsync();
        }

        public async Task<PrerequisiteEntity?> Update(UpdatePrerequisiteDto dto) {
            var prerequisite = await db.Prerequisites.FindAsync(dto.Id);

            if (prerequisite == null)
                return null;

            prerequisite.Prerequisite = dto.Prerequisite;

            await db.SaveChangesAsync();

            return prerequisite;
        }

        public async Task<PrerequisiteEntity?> Delete(int id) {
            var prerequisite = await db.Prerequisites.FindAsync(id);

            if (prerequisite == null)
                return null;

            db.Prerequisites.Remove(prerequisite);
            await db.SaveChangesAsync();

            return prerequisite;
        }
    }
}