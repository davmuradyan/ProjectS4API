namespace ProjectS4API.Data.Entities
{
    public record MethodToolEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public CourseEntity? Course { get; set; }
        public int MethodId { get; set; }
        public MethodEntity? Method { get; set; }

    }
}
