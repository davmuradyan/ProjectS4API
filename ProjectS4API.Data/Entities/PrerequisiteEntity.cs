namespace ProjectS4API.Data.Entities
{
    public record PrerequisiteEntity
    {
        public int Id { get; set; }
        public required string Prerequisite { get; set; }
    }
}
