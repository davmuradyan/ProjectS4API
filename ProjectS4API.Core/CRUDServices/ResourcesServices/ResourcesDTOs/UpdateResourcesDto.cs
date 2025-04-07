using System.ComponentModel.DataAnnotations;

public class UpdateResourcesDto {
    [Required]
    public int Id { get; set; }

    [Required]
    public string Core { get; set; }
    
    [Required]
    public string Additional { get; set; } = string.Empty;

    [Required]
    public string Web { get; set; }
}