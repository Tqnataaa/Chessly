using Chessly.Web.Data;
using Chessly.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chessly.Web.Controllers
{
    public class GameController : Controller
    {
        public readonly ApplicationDbContext Context;

        public GameController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public async Task<IActionResult> Play()
        {
            var bots = await Context.Bots.AsNoTracking().ToListAsync();

            var model = new ViewModels.PlayGameViewModel
            {
                AvailableBots = bots
            };

            return View(model);
        }
    }
}
