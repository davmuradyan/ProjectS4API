using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Data.DAO {
    public class MainDbContext : DbContext {
        public MainDbContext(DbContextOptions options) : base(options) { }

        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<CoursePrerequisiteEntity> Course_Prerequisites { get; set; }
        public DbSet<DoHEntity> Distribution_of_Hours { get; set; }
        public DbSet<EvaluationEntity> Evaluations { get; set; }
        public DbSet<ExamEntity> Exams { get; set; }
        public DbSet<HourEntity> Hours { get; set; }
        public DbSet<KnowledgeEntity> Knowledge { get; set; }
        public DbSet<MethodEntity> Methods { get; set; }
        public DbSet<MethodToolEntity> Methods_and_Tools { get; set; }
        public DbSet<OngoingEvalEntity> Ongoing_Evaluations { get; set; }
        public DbSet<PrerequisiteEntity> Prerequisites { get; set; }
        public DbSet<ProfessorEntity> Professors { get; set; }
        public DbSet<ResourcesEntity> Resources { get; set; }
        public DbSet<TopicEntity> Topics { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EvaluationEntity>()
                .HasOne(e => e.Midterm)
                .WithMany()
                .HasForeignKey(e => e.MidtermId)
                .OnDelete(DeleteBehavior.Restrict); // 👈 Replace CASCADE

            modelBuilder.Entity<EvaluationEntity>()
                .HasOne(e => e.Final)
                .WithMany()
                .HasForeignKey(e => e.FinalId)
                .OnDelete(DeleteBehavior.Cascade); // 👈 Keep only one CASCADE

            modelBuilder.Entity<EvaluationEntity>()
                .HasOne(e => e.OngoingEval)
                .WithMany()
                .HasForeignKey(e => e.OngoingEvalId)
                .OnDelete(DeleteBehavior.Restrict); // 👈 Or NoAction
        }

    }
}