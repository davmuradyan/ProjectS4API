namespace ProjectS4API.Data.Entities
{
    public record EvalCharsEntity
    {
        public int Id { get; set; }
        public bool Oral { get; set; }
        public float Duration { get; set; }
        public string Type { get; set; }
    }
}
