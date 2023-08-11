namespace PostgreSQL.Data
{
    public class Entry
    {
        public int Id { get; set; }
        public List<Track> Tracks { get; set; }
        public DateTime Date { get; set; }
    }
}