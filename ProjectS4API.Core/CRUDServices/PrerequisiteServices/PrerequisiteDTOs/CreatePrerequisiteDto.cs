using System.ComponentModel.DataAnnotations;

public class CreatePrerequisiteDto {
    [Required]
    [MaxLength(200)]
    public string Prerequisite { get; set; }
}