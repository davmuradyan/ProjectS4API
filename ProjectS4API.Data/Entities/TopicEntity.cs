namespace ProjectS4API.Data.Entities
{
    public record TopicEntity
    {
        public int Id { get; set; }
        public required string Topic { get; set; }
        public required string CoreResources { get; set; }
        public string AdditionalResources { get; set; } = string.Empty;
        public int HourId { get; set; }
        public HourEntity? Hour { get; set; }
        public int CourseId { get; set; }
        public CourseEntity? Course { get; set; }
    }
}
