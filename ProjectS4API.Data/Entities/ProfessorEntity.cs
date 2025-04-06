namespace ProjectS4API.Data.Entities
{
    public record ProfessorEntity {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Degree { get; set; }

    }
}
