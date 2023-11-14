using System.ComponentModel.DataAnnotations;

namespace CinemaMVC.Models
{
    public class Places
    {
        [Key]
        public int Id { get; set; }
        public int Number {  get; set; }
        public decimal Price {  get; set; }
        public List<Tickets> Tickets { get; set; }
    }
}
