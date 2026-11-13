using Chessly.Web.Models;
using Microsoft.AspNetCore.Identity;
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

            builder.Entity<ApplicationUser>().HasData(GenerateSeededUsers(50));
        }

        private static List<ApplicationUser> GenerateSeededUsers(int count = 50)
        {
            var list = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();
            var random = new Random(42);

            for (int i = 1; i <= count; i++)
            {
                string username = $"test{i:D3}";
                string email = $"{username}@test.com";

                var user = new ApplicationUser
                {
                    Id = $"00000000-0000-0000-0000-{i:D12}",
                    UserName = username,
                    NormalizedUserName = username.ToUpperInvariant(),
                    Email = email,
                    NormalizedEmail = email.ToUpperInvariant(),
                    EmailConfirmed = true,
                    SecurityStamp = $"security-stamp-{i:D3}",
                    ConcurrencyStamp = $"concurrency-stamp-{i:D3}",
                    Elo = random.Next(600, 3501),
                    Wins = random.Next(0, 100),
                    Losses = random.Next(0, 80),
                    Draws = random.Next(0, 20)
                };

                user.PasswordHash = hasher.HashPassword(user, "123");
                list.Add(user);
            }

            return list;
        }
    }
}
