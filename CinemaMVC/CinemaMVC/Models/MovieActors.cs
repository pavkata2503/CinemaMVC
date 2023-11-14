using System.ComponentModel.DataAnnotations;

namespace CinemaMVC.Models
{
    public class MovieActors
    {
        public Movies MovieId { get; set; }
        public Actors ActorId { get; set; }
    }
}
