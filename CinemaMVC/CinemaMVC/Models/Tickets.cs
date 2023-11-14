using System.ComponentModel.DataAnnotations;

namespace CinemaMVC.Models
{
    public class Tickets
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int MovieId { get; set; }
        public Movies Movie{ get; set; }
        public int VisitorId { get; set; }
        public VIsitors Visitor { get; set; }
        public int PlaceId { get; set; }
        public Places Place { get; set; }
        public decimal Price { get; set; }
    }
}
