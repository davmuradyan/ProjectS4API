using System.ComponentModel.DataAnnotations;

namespace ProjectS4API.Data.Entities {
    public record ExampleEntity {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Description { get; set; }
    }
}
