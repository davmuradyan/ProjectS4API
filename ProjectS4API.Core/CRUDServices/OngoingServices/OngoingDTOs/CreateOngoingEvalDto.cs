using System.ComponentModel.DataAnnotations;

public class CreateOngoingEvalDto {
    [Required]
    public bool isProject { get; set; }

    [Required]
    public bool isPresentation { get; set; }

    [Required]
    [MaxLength(500)]
    public string Criteria { get; set; }

    [Required]
    public bool Oral { get; set; }
    [Required]
    public float Duration { get; set; }
    [Required]
    public string Type { get; set; }
}