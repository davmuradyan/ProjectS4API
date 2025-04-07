using System.ComponentModel.DataAnnotations;

public class UpdateKnowledgeDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Level { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public int CourseId { get; set; }
}
