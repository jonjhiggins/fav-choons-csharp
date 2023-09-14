using System.ComponentModel.DataAnnotations;

namespace fav_choons_csharp.Data.Models
{
    public class Artist
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
    }
}