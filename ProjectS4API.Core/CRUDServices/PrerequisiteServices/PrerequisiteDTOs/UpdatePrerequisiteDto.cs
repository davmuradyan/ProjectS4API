using System.ComponentModel.DataAnnotations;

public class UpdatePrerequisiteDto {
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Prerequisite { get; set; }
}