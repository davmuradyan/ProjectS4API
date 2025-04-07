using System.ComponentModel.DataAnnotations;

public class UpdateMethodToolDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int CourseId { get; set; }

    [Required]
    public int MethodId { get; set; }
}
