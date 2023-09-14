using System.ComponentModel.DataAnnotations;

namespace fav_choons_csharp.Data.Models
{
    public class Entry
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public List<Track> Tracks { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}