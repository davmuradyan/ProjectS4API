using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.OngoingEvalServices {
    public class OngoingEvalCRUDService : IOngoingEvalCRUDService {
        private readonly MainDbContext db;

        public OngoingEvalCRUDService(MainDbContext mainDb) {
            db = mainDb;
        }

        public async Task<OngoingEvalEntity> Create(CreateOngoingEvalDto dto) {
            var ongoingEval = new OngoingEvalEntity {
                isProject = dto.isProject,
                isPresentation = dto.isPresentation,
                Criteria = dto.Criteria,
                Oral = dto.Oral,
                Duration = dto.Duration,
                Type = dto.Type,
                
            };

            db.Ongoing_Evaluations.Add(ongoingEval);
            await db.SaveChangesAsync();

            return ongoingEval;
        }

        public async Task<OngoingEvalEntity?> Read(int id) {
            return await db.Ongoing_Evaluations.FindAsync(id);
        }

        public async Task<ICollection<OngoingEvalEntity>> ReadAll() {
            return await db.Ongoing_Evaluations.ToListAsync();
        }

        public async Task<OngoingEvalEntity?> Update(UpdateOngoingEvalDto dto) {
            var ongoingEval = await db.Ongoing_Evaluations.FindAsync(dto.Id);

            if (ongoingEval == null)
                return null;

            ongoingEval.isProject = dto.isProject;
            ongoingEval.isPresentation = dto.isPresentation;
            ongoingEval.Criteria = dto.Criteria;
            ongoingEval.Oral = dto.Oral;
            ongoingEval.Duration = dto.Duration;
            ongoingEval.Type = dto.Type;

            await db.SaveChangesAsync();

            return ongoingEval;
        }

        public async Task<OngoingEvalEntity?> Delete(int id) {
            var ongoingEval = await db.Ongoing_Evaluations.FindAsync(id);

            if (ongoingEval == null)
                return null;

            db.Ongoing_Evaluations.Remove(ongoingEval);
            await db.SaveChangesAsync();

            return ongoingEval;
        }
    }
}