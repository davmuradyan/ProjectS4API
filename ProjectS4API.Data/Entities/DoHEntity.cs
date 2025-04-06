namespace ProjectS4API.Data.Entities
{
    public record DoHEntity
    {
        public int Id { get; set; }
        public float CM { get; set; }
        public float TP { get; set; }
        public float TPS { get; set; }
        public int ECT { get; set; }
    }
}
