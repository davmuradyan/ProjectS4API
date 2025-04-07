using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.ResourcesServices {
    public class ResourcesCRUDService : IResourcesCRUDService {
        private readonly MainDbContext db;

        public ResourcesCRUDService(MainDbContext mainDb) {
            db = mainDb;
        }

        public async Task<ResourcesEntity> Create(CreateResourcesDto dto) {
            var resources = new ResourcesEntity {
                Core = dto.Core,
                Additional = dto.Additional,
                Web = dto.Web
            };

            db.Resources.Add(resources);
            await db.SaveChangesAsync();

            return resources;
        }

        public async Task<ResourcesEntity?> Read(int id) {
            return await db.Resources.FindAsync(id);
        }

        public async Task<ICollection<ResourcesEntity>> ReadAll() {
            return await db.Resources.ToListAsync();
        }

        public async Task<ResourcesEntity?> Update(UpdateResourcesDto dto) {
            var resources = await db.Resources.FindAsync(dto.Id);

            if (resources == null)
                return null;

            resources.Core = dto.Core;
            resources.Additional = dto.Additional;
            resources.Web = dto.Web;

            await db.SaveChangesAsync();

            return resources;
        }

        public async Task<ResourcesEntity?> Delete(int id) {
            var resources = await db.Resources.FindAsync(id);

            if (resources == null)
                return null;

            db.Resources.Remove(resources);
            await db.SaveChangesAsync();

            return resources;
        }
    }
}