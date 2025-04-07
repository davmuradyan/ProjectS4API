using System.ComponentModel.DataAnnotations;

public class CreateMethodToolDto
{
    [Required]
    public int CourseId { get; set; }

    [Required]
    public int MethodId { get; set; }
}
