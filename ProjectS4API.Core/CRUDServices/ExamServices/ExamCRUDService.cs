using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.CRUDServices.ExamServices
{
    public class ExamCRUDService : IExamCRUDService
    {
        private readonly MainDbContext db;

        public ExamCRUDService(MainDbContext context)
        {
            db = context;
        }

        public async Task<ExamEntity> Create(CreateExamDto dto)
        {
            var exam = new ExamEntity
            {
                Oral = dto.Oral,
                Duration = dto.Duration,
                Type = dto.Type,
                isFinal = dto.isFinal,
                isGroupBased = dto.isGroupBased
            };

            db.Exams.Add(exam);
            await db.SaveChangesAsync();
            return exam;
        }

        public async Task<ExamEntity?> Read(int id)
        {
            return await db.Exams.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<ICollection<ExamEntity>> ReadAll()
        {
            return await db.Exams.ToListAsync();
        }

        public async Task<ExamEntity?> Update(UpdateExamDto dto)
        {
            var exam = await db.Exams.FindAsync(dto.Id);
            if (exam == null) return null;

            exam.Oral = dto.Oral;
            exam.Duration = dto.Duration;
            exam.Type = dto.Type;
            exam.isFinal = dto.isFinal;
            exam.isGroupBased = dto.isGroupBased;

            await db.SaveChangesAsync();
            return exam;
        }

        public async Task<ExamEntity?> Delete(int id)
        {
            var exam = await db.Exams.FindAsync(id);
            if (exam == null) return null;

            db.Exams.Remove(exam);
            await db.SaveChangesAsync();
            return exam;
        }
    }
}
