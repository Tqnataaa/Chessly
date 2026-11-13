using Chessly.Web.Data;
using Chessly.Web.Models;
using Chessly.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Chessly.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task<IActionResult> Leaderboard()
        {
            
            var topPlayers = await _context.Set<ApplicationUser>()
                .AsNoTracking()
                .OrderByDescending(u => u.Elo)
                .ThenByDescending(u => u.Wins)
                .Take(100)
                .Select(u => new
                {
                    u.UserName,
                    u.Elo,
                    u.Wins,
                    u.Losses,
                    u.Draws
                })
                .ToListAsync();

            
            var leaderboard = topPlayers.Select((u, index) => new LeaderboardViewModel
            {
                Rank = index + 1,
                UserName = u.UserName ?? "Anonymous Player",
                Elo = u.Elo,
                Wins = u.Wins,
                Losses = u.Losses,
                Draws = u.Draws
            }).ToList();

            return View(leaderboard);
        }
    }
}
