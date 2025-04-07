using System.ComponentModel.DataAnnotations;

public class CreateProfessorDto {
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [MaxLength(100)]
    public string Surname { get; set; }

    [Required]
    [MaxLength(50)]
    public string Degree { get; set; }
}