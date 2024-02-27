namespace KPMovieFlex.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public required string MovieName { get; set; }
        public required string Genre { get; set; }
        public required string Ott { get; set; }
        public required string Language { get; set; }
    }
}
