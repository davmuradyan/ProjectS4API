using System.ComponentModel.DataAnnotations;

public class CreateMethodDto
{
    [Required]
    [MaxLength(100)]
    public string Method { get; set; }
}
