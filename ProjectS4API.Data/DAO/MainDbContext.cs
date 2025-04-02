using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Data.DAO {
    public class MainDbContext : DbContext {
        public MainDbContext(DbContextOptions options) : base(options) { }

        // Here write down your collection. For example:
        // If we have StudentEntity, write the following:
        // public DbSet<StudentEntity> Students { get; set; }

        public DbSet<ExampleEntity> Examples { get; set; }
    }
}