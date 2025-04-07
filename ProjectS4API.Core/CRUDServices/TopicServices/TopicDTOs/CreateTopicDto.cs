using System.ComponentModel.DataAnnotations;

public class CreateTopicDto {
    [Required]
    [MaxLength(100)]
    public string Topic { get; set; }

    [Required]
    public string CoreResources { get; set; }

    public string AdditionalResources { get; set; } = string.Empty;

    [Required]
    public int HourId { get; set; }

    [Required]
    public int CourseId { get; set; }
}