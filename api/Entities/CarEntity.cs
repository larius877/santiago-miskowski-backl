using System.ComponentModel.DataAnnotations;

namespace api.Entities
{
    public class CarEntity
    {
        [Key]
        public int? id { get; set; }
        [Required]
        public string? model { get; set; }
        [Required]
        public string? brand { get; set; }
    }
}
