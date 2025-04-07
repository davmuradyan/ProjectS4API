using System.ComponentModel.DataAnnotations;

public class UpdateDoHDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public float CM { get; set; }

    [Required]
    public float TP { get; set; }

    [Required]
    public float TPS { get; set; }

    [Required]
    public int ECT { get; set; }
}
