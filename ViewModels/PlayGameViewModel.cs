using Chessly.Web.Models;
namespace Chessly.Web.ViewModels
{
    public class PlayGameViewModel
    {
        public List<Bot> AvailableBots { get; set; } = new List<Bot>();
        public int SelectedBotId { get; set; }
    }

    public class BotMoveInput
    {
        public int BotId { get; set; }
        public List<string> LegalMoves { get; set; } = new List<string>();
        public string Difficulty { get; set; } = "Easy";

    }

    public class SaveGameInputModel
    {
        public int BotId { get; set; }
        public string Result { get; set; } = "Loss";
        public string Notation { get; set; } = string.Empty;
    }
}
