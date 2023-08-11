namespace PostgreSQL.Data
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<Entry> Entries { get; set; }
    }
}