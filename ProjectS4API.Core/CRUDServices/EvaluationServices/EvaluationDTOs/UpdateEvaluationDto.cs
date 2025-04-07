using System.ComponentModel.DataAnnotations;

public class UpdateEvaluationDto : CreateEvaluationDto
{
    [Required]
    public int Id { get; set; }
}
