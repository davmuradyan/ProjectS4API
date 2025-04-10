namespace ProjectS4API.Data.Entities
{
    public record ResourcesEntity
    {
        public int Id { get; set; }
        public required string Core { get; set; }
        public string? Additional { get; set; } = null!;
        public string? Web { get; set; } = null!;
    }
}
