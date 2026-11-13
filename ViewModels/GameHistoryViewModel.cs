namespace Chessly.Web.ViewModels
{
    public class GameHistoryViewModel
    {
        public int Id { get; set; }
        public string BotName { get; set; } = string.Empty;
        public string? BotImageUrl { get; set; }
        public int BotElo { get; set; }
        public string Result { get; set; } = string.Empty;
        public DateTime PlayedOn { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? PgnMoves { get; set; }
    }
}
