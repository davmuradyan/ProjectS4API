using System.ComponentModel.DataAnnotations;

public class CreateEvaluationDto
{
    [Required]
    public int OngoingEvalId { get; set; }

    [Required]
    public int MidtermId { get; set; }

    [Required]
    public int FinalId { get; set; }
}
