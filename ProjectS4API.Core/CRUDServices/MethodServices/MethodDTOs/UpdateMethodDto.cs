using System.ComponentModel.DataAnnotations;

public class UpdateMethodDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Method { get; set; }
}
