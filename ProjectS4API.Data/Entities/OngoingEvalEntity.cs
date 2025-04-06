namespace ProjectS4API.Data.Entities
{
    public record OngoingEvalEntity
    {
        public int Id { get; set; }
        public bool isProject { get; set; }
        public bool isPresentation { get; set; }
        public required string Criteria { get; set; }
        public int EvalCharsId { get; set; }
        public EvalCharsEntity? EvalChars { get; set; }
    }
}
