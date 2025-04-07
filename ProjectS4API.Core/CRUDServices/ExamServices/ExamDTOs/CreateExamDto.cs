using System.ComponentModel.DataAnnotations;

public class CreateExamDto
{
    [Required]
    public bool Oral { get; set; }

    [Required]
    public float Duration { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public bool isFinal { get; set; }

    [Required]
    public bool isGroupBased { get; set; }
}
