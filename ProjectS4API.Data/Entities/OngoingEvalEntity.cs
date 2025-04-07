namespace ProjectS4API.Data.Entities
{
    public record OngoingEvalEntity : EvalCharsEntity
    {
        public bool isProject { get; set; }
        public bool isPresentation { get; set; }
        public required string Criteria { get; set; }
    }
}
