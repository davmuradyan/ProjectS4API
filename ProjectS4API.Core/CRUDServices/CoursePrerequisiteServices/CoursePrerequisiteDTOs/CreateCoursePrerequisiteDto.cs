using System.ComponentModel.DataAnnotations;

public class CreateCoursePrerequisiteDto
{
    [Required]
    public int CourseId { get; set; }

    [Required]
    public int Prerequisite { get; set; }
}
