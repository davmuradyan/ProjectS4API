using System.ComponentModel.DataAnnotations;

public class CreateEvaluationDto
{
    public int? OngoingEvalId { get; set; }

    public int? MidtermId { get; set; }

    [Required]
    public int FinalId { get; set; }
}
