using System.ComponentModel.DataAnnotations;

namespace fav_choons_csharp.Data.Models
{
    public class Track
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Artist Artist { get; set; }
    }
}