using System.ComponentModel.DataAnnotations;

namespace CinemaMVC.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string Title {  get; set; }
        public int GenreId {  get; set; }
        public Genres Genre {  get; set; }
        public List<MovieActors> MovieActors { get; set; }
        public string Poster {  get; set; }
        public string Plot { get; set; }
        public double VisitorsRating { get; set; }
        public DateTime ProjectionWeek {  get; set; }
        public decimal Price {  get; set; }
        public List<Tickets> Tickets {  get; set; }
    }
}
