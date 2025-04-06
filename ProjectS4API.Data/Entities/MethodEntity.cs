namespace ProjectS4API.Data.Entities
{
    public record MethodEntity
    {
        public int Id { get; set; }
        public required string Method { get; set; }
    }
}
