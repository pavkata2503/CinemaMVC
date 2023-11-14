using CinemaMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<VIsitors> VIsitors { get; set; }
        public DbSet<Places> Places { get; set; }
        public DbSet<MovieActors> MovieActors { get; set; }
    }
}