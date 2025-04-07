using System.ComponentModel.DataAnnotations;

public class UpdateExamDto : CreateExamDto
{
    [Required]
    public int Id { get; set; }
}
