using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.EvaluationServices
{
    public class EvaluationCRUDService : IEvaluationCRUDService
    {
        private readonly MainDbContext db;

        public EvaluationCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<EvaluationEntity> Create(CreateEvaluationDto dto)
        {
            var evaluation = new EvaluationEntity
            {
                OngoingEvalId = dto.OngoingEvalId,
                MidtermId = dto.MidtermId,
                FinalId = dto.FinalId
            };

            db.Evaluations.Add(evaluation);
            await db.SaveChangesAsync();
            return evaluation;
        }

        public async Task<EvaluationEntity?> Read(int id)
        {
            return await db.Evaluations
                .Include(e => e.OngoingEval)
                .Include(e => e.Midterm)
                .Include(e => e.Final)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<ICollection<EvaluationEntity>> ReadAll()
        {
            return await db.Evaluations
                .Include(e => e.OngoingEval)
                .Include(e => e.Midterm)
                .Include(e => e.Final)
                .ToListAsync();
        }

        public async Task<EvaluationEntity?> Update(UpdateEvaluationDto dto)
        {
            var evaluation = await db.Evaluations.FindAsync(dto.Id);
            if (evaluation == null) return null;

            evaluation.OngoingEvalId = dto.OngoingEvalId;
            evaluation.MidtermId = dto.MidtermId;
            evaluation.FinalId = dto.FinalId;

            await db.SaveChangesAsync();
            return evaluation;
        }

        public async Task<EvaluationEntity?> Delete(int id)
        {
            var evaluation = await db.Evaluations.FindAsync(id);
            if (evaluation == null) return null;

            db.Evaluations.Remove(evaluation);
            await db.SaveChangesAsync();
            return evaluation;
        }
    }
}
