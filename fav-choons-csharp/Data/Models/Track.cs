using System.ComponentModel.DataAnnotations;

namespace fav_choons_csharp.Data.Models
{
    public class Track
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required Artist Artist { get; set; }
    }
}