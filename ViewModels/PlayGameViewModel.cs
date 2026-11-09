using Chessly.Web.Models;

namespace Chessly.Web.ViewModels
{
    public class PlayGameViewModel
    {
        public List<Bot> AvailableBots { get; set; } = new List<Bot>();
    }
}
