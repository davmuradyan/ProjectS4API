using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.ProfessorServices {
    public class ProfessorCRUDService : IProfessorCRUDService {
        private readonly MainDbContext db;

        public ProfessorCRUDService(MainDbContext mainDb) {
            db = mainDb;
        }

        public async Task<ProfessorEntity> Create(CreateProfessorDto dto) {
            var professor = new ProfessorEntity {
                Name = dto.Name,
                Surname = dto.Surname,
                Degree = dto.Degree
            };

            db.Professors.Add(professor);
            await db.SaveChangesAsync();

            return professor;
        }

        public async Task<ProfessorEntity?> Read(int id) {
            return await db.Professors.FindAsync(id);
        }

        public async Task<ICollection<ProfessorEntity>> ReadAll() {
            return await db.Professors.ToListAsync();
        }

        public async Task<ProfessorEntity?> Update(UpdateProfessorDto dto) {
            var professor = await db.Professors.FindAsync(dto.Id);

            if (professor == null)
                return null;

            professor.Name = dto.Name;
            professor.Surname = dto.Surname;
            professor.Degree = dto.Degree;

            await db.SaveChangesAsync();

            return professor;
        }

        public async Task<ProfessorEntity?> Delete(int id) {
            var professor = await db.Professors.FindAsync(id);

            if (professor == null)
                return null;

            db.Professors.Remove(professor);
            await db.SaveChangesAsync();

            return professor;
        }
    }
}