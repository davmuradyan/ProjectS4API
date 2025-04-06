namespace ProjectS4API.Data.Entities
{
    public record CoursePrerequisiteEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public CourseEntity? Course { get; set; }
        public int Prerequisite { get; set; }
        public PrerequisiteEntity? PrerequisiteEntity { get; set; }
    }
}
