using System.ComponentModel.DataAnnotations;

public class CreateCourseDto
{
    [Required]
    [MaxLength(100)]
    public string CourseName { get; set; }

    [Required]
    public string Degree { get; set; }

    [Required]
    public string Qualification { get; set; }

    [Required]
    public int ProfessorId { get; set; }

    [Required]
    public int DoHId { get; set; }

    [Required]
    public string AcademicYear { get; set; }

    [Required]
    public int EvaluationId { get; set; }

    [Required]
    public int ResourcesId { get; set; }

    [Required]
    public int Year { get; set; }

    public string ToolsDescription { get; set; } = string.Empty;
}
