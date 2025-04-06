namespace ProjectS4API.Data.Entities
{
    public record CourseEntity
    {
        public int Id { get; set; }
        public required string CourseName { get; set; }
        public required string Degree { get; set; }
        public required string Qualification { get; set; }
        public int ProfessorId { get; set; }
        public ProfessorEntity? Professor { get; set; }
        public int DoHId {  get; set; }
        public DoHEntity? DoH { get; set; }
        public required string AcademicYear { get; set; }
        public int EvaluationId { get; set; }
        public EvaluationEntity? Evaluation { get; set; }
        public string ToolsDescription { get; set; } = string.Empty;
        public int ResourcesId { get; set; }
        public ResourcesEntity? Resources { get; set; }
        public int Year { get; set; }
    }
}
