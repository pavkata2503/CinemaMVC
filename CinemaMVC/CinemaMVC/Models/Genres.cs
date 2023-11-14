using System.ComponentModel.DataAnnotations;

namespace CinemaMVC.Models
{
    public class Genres
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movies> Movies { get; set; }
        
    }
}
