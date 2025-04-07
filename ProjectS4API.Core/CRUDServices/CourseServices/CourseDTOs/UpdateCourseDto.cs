using System.ComponentModel.DataAnnotations;

public class UpdateCourseDto : CreateCourseDto
{
    [Required]
    public int Id { get; set; }
}
