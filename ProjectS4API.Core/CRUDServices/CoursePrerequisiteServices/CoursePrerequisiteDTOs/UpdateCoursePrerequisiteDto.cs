using System.ComponentModel.DataAnnotations;

public class UpdateCoursePrerequisiteDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int CourseId { get; set; }

    [Required]
    public int Prerequisite { get; set; }
}
