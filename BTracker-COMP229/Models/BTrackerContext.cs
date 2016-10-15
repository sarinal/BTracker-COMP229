namespace BTracker_COMP229.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BTrackerContext : DbContext
    {
        public BTrackerContext()
            : base("name=BTrackerConnection")
        {
        }

        public virtual DbSet<game> games { get; set; }
        public virtual DbSet<team> teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<game>()
                .Property(e => e.home_team)
                .IsUnicode(false);

            modelBuilder.Entity<game>()
                .Property(e => e.away_team)
                .IsUnicode(false);

            modelBuilder.Entity<game>()
                .Property(e => e.winner)
                .IsUnicode(false);

            modelBuilder.Entity<game>()
                .Property(e => e.loser)
                .IsUnicode(false);

            modelBuilder.Entity<team>()
                .Property(e => e.team1)
                .IsUnicode(false);

            modelBuilder.Entity<team>()
                .Property(e => e.league)
                .IsUnicode(false);

            modelBuilder.Entity<team>()
                .Property(e => e.division)
                .IsUnicode(false);

            modelBuilder.Entity<team>()
                .Property(e => e.team_id)
                .IsUnicode(false);
        }
    }
}
