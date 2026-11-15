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

            const string testerId = "tester-user-id-0001";
            var hasher = new PasswordHasher<ApplicationUser>();

            var tester = new ApplicationUser
            {
                Id = testerId,
                UserName = "Tester",
                NormalizedUserName = "TESTER",
                Email = "tester@acc.test",
                NormalizedEmail = "TESTER@ACC.TEST",
                EmailConfirmed = true,
                SecurityStamp = "STATIC-SECURITY-STAMP-0001",
                ConcurrencyStamp = "STATIC-CONCURRENCY-STAMP-0001",
                Elo = 1230,
                Wins = 10,
                Losses = 7,
                Draws = 3
            };
            tester.PasswordHash = hasher.HashPassword(tester, "123");

            builder.Entity<ApplicationUser>().HasData(tester);

            var baseDate = new DateTime(2026, 11, 1, 12, 0, 0, DateTimeKind.Utc);

            builder.Entity<GameHistory>().HasData(
                new GameHistory { Id = 1001, UserId = testerId, BotId = 1, Title = "Match #1", Result = "Win", PgnMoves = "1. e4 e5 2. Nf3 Nc6 3. Bb5 a6 1-0", PlayedOn = baseDate.AddDays(1) },
                new GameHistory { Id = 1002, UserId = testerId, BotId = 1, Title = "Match #2", Result = "Win", PgnMoves = "1. d4 d5 2. c4 e6 3. Nc3 Nf6 0-1", PlayedOn = baseDate.AddDays(2) },
                new GameHistory { Id = 1003, UserId = testerId, BotId = 2, Title = "Match #3", Result = "Loss", PgnMoves = "1. e4 c5 2. Nf3 d6 3. d4 cxd4 0-1", PlayedOn = baseDate.AddDays(3) },
                new GameHistory { Id = 1004, UserId = testerId, BotId = 1, Title = "Match #4", Result = "Draw", PgnMoves = "1. e4 e6 2. d4 d5 3. Nc3 Bb4 1/2-1/2", PlayedOn = baseDate.AddDays(4) },
                new GameHistory { Id = 1005, UserId = testerId, BotId = 2, Title = "Match #5", Result = "Win", PgnMoves = "1. c4 e5 2. Nc3 Nf6 3. g3 d5 1-0", PlayedOn = baseDate.AddDays(5) },
                new GameHistory { Id = 1006, UserId = testerId, BotId = 3, Title = "Match #6", Result = "Loss", PgnMoves = "1. e4 e5 2. Bc4 Nc6 3. Qh5 Nf6 1-0", PlayedOn = baseDate.AddDays(6) },
                new GameHistory { Id = 1007, UserId = testerId, BotId = 1, Title = "Match #7", Result = "Win", PgnMoves = "1. d4 Nf6 2. c4 g6 3. Nc3 Bg7 1-0", PlayedOn = baseDate.AddDays(7) },
                new GameHistory { Id = 1008, UserId = testerId, BotId = 2, Title = "Match #8", Result = "Loss", PgnMoves = "1. e4 c6 2. d4 d5 3. Nc3 dxe4 1-0", PlayedOn = baseDate.AddDays(8) },
                new GameHistory { Id = 1009, UserId = testerId, BotId = 1, Title = "Match #9", Result = "Win", PgnMoves = "1. Nf3 d5 2. g3 c5 3. Bg2 Nc6 1-0", PlayedOn = baseDate.AddDays(9) },
                new GameHistory { Id = 1010, UserId = testerId, BotId = 2, Title = "Match #10", Result = "Draw", PgnMoves = "1. e4 e5 2. Nf3 Nf6 3. Nxe5 d6 1/2-1/2", PlayedOn = baseDate.AddDays(10) },
                new GameHistory { Id = 1011, UserId = testerId, BotId = 3, Title = "Match #11", Result = "Loss", PgnMoves = "1. d4 f5 2. g3 Nf6 3. Bg2 e6 0-1", PlayedOn = baseDate.AddDays(11) },
                new GameHistory { Id = 1012, UserId = testerId, BotId = 1, Title = "Match #12", Result = "Win", PgnMoves = "1. e4 d5 2. exd5 Qxd5 3. Nc3 Qa5 0-1", PlayedOn = baseDate.AddDays(12) }
            );
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
