namespace ProjectS4API.Data.Entities
{
    public record ExamEntity
    {
        public int Id { get; set; }
        public bool isFinal { get; set; }
        public bool isGroupBased { get; set; }
        public int EvalCharsId { get; set; }
        public EvalCharsEntity? EvalChars {  get; set; } 
    } 
}
