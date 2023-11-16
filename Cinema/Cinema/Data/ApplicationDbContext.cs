using Cinema.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>()
                .HasOne(m => m.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(m => m.GenreId);

            modelBuilder.Entity<MovieActor>()
                .HasKey(ma => new {ma.MovieId, ma.ActorId});

            modelBuilder.Entity<MovieActor>()
                .HasOne(ma=>ma.Movie)
                .WithMany(m=>m.MovieActors)
                .HasForeignKey(ma=>ma.MovieId);

            modelBuilder.Entity<MovieActor>()
                .HasOne(t => t.Actor)
                .WithMany(a => a.MovieActors)
                .HasForeignKey(t => t.ActorId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Movie)
                .WithMany(m => m.Tickets)
                .HasForeignKey(t => t.MovieId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Visitor)
                .WithMany(v => v.Tickets)
                .HasForeignKey(ma => ma.VisitorId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Place)
                .WithMany(p => p.Tickets)
                .HasForeignKey(t => t.PlaceId);
        }
    }
}