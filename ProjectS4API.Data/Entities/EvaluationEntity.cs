namespace ProjectS4API.Data.Entities
{
    public record EvaluationEntity
    {
        public int Id { get; set; }
        public int OngoingEvalId { get; set; }
        public OngoingEvalEntity? OngoingEval { get; set; }
        public int MidtermId { get; set; }
        public ExamEntity? Midterm { get; set; }
        public int FinalId { get; set; }
        public ExamEntity? Final { get; set; }

    }
}
