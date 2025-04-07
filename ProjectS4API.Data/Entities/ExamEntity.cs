namespace ProjectS4API.Data.Entities
{
    public record ExamEntity : EvalCharsEntity 
    {
        public bool isFinal { get; set; }
        public bool isGroupBased { get; set; }
    } 
}
