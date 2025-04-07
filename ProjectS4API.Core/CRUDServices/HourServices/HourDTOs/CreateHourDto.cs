using System.ComponentModel.DataAnnotations;

public class CreateHourDto
{
    [Required]
    [Range(0, float.MaxValue)]
    public float CM { get; set; }

    [Required]
    [Range(0, float.MaxValue)]
    public float TD { get; set; }
}
