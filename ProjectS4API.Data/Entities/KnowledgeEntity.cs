namespace ProjectS4API.Data.Entities
{
    public record KnowledgeEntity
    {
        public int Id { get; set; }
        public required string Level { get; set; }
        public required string Description { get; set; }
        public int CourseId { get; set; }
        public CourseEntity? Course { get; set; }
    }
}
