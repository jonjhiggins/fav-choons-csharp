using System.ComponentModel.DataAnnotations;

namespace fav_choons_csharp.Data.Models
{
    public class AppUser
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public required string Username { get; set; }
        [Required]
        public required string Email { get; set; }
        public List<Entry>? Entries { get; set; }
    }
}