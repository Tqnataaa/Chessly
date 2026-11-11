using Chessly.Web.Data;
using Chessly.Web.Models;
using Chessly.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chessly.Web.Controllers
{
    public class GameController : Controller
    {
        public readonly ApplicationDbContext Context;
        private readonly UserManager<ApplicationUser> UserManager;
        private static readonly Random random = new Random();

        public GameController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.Context = context;
            this.UserManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Play()
        {
            var bots = await this.Context.Set<Bot>().ToListAsync();

            var viewModel = new PlayGameViewModel
            {
                AvailableBots = bots
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> MakeBotMove([FromBody] BotMoveInput input)
        {
            if (input.LegalMoves == null || input.LegalMoves.Count == 0)
            {
                return Json(new { move = "" });
            }

            var bot = await this.Context.Set<Bot>().FindAsync(input.BotId);
            int botElo = bot != null ? bot.Elo : 600;

            string chosenMove;

            if (botElo <= 600)
            {
                chosenMove = input.LegalMoves[random.Next(input.LegalMoves.Count)];
            }
            else
            {
                var captureMoves = input.LegalMoves.FindAll(m => m.Contains('x'));
                if (captureMoves.Count > 0)
                {
                    chosenMove = captureMoves[random.Next(captureMoves.Count)];
                }
                else
                {
                    chosenMove = input.LegalMoves[random.Next(input.LegalMoves.Count)];
                }
            }

            return Json(new { move = chosenMove });
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> SaveGame([FromBody] SaveGameInputModel input)
        {
            if (User?.Identity == null || !User.Identity.IsAuthenticated)
            {
                return Ok(new { saved = false, message = "User is not logged in. Game was not saved." });
            }

            var user = await this.UserManager.GetUserAsync(User);

            var bot = await this.Context.Set<Bot>().FindAsync(input.BotId);
            string botName = bot != null ? bot.Name : "Bot";

            var game = new GameHistory
            {
                UserId = user.Id,
                UserName = user.UserName ?? "Unknown Player",
                BotId = input.BotId,
                BotName = botName,
                Result = input.Result,
                PlayedOn = DateTime.UtcNow,
                Title = $"Match vs {botName}",
                Notes = "Casual Match",
                PgnMoves = string.IsNullOrWhiteSpace(input.Notation) ? "N/A" : input.Notation
            };

            this.Context.Set<GameHistory>().Add(game);

            if (input.Result == "Win")
            {
                user.Wins++;
                user.Elo += 15;
            }
            else if (input.Result == "Loss")
            {
                user.Losses++;
                user.Elo = Math.Max(100, user.Elo - 15);
            }
            else
            {
                user.Draws++;
            }

            await this.Context.SaveChangesAsync();

            return Ok();
        }
    }
}