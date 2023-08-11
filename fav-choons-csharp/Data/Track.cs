namespace PostgreSQL.Data
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
    }
}