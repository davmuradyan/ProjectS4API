using System.ComponentModel.DataAnnotations;

public class CreateResourcesDto {
    [Required]
    public string Core { get; set; }

    public string Additional { get; set; } = string.Empty;

    public string Web { get; set; }
}