using Chessly.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chessly.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bot> Bots { get; set; } = null!;
        public DbSet<GameHistory> GameHistories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Configure the relationships and constraints for GameHistory
            builder.Entity<GameHistory>()
                .HasOne(gh => gh.Bot)
                .WithMany(b => b.Matches)
                .HasForeignKey(gh => gh.BotId)
                .OnDelete(DeleteBehavior.Restrict);
       
            builder.Entity<Bot>().HasData(
                new Bot { Id = 1, Name = "PawnBot", Difficulty = "Easy", Elo = 600, Description = "An easy bot for beginners.", ImageUrl = "/img/chesspieces/wikipedia/wP.png" },
                new Bot { Id = 2, Name = "KnightBot", Difficulty = "Medium", Elo = 1200, Description = "A medium difficulty bot.", ImageUrl = "/img/chesspieces/wikipedia/wN.png" },
                new Bot { Id = 3, Name = "QueenBot", Difficulty = "Hard", Elo = 1800, Description = "A challenging bot for experienced players.", ImageUrl = "/img/chesspieces/wikipedia/wQ.png" }
            );
        }
    }
}
