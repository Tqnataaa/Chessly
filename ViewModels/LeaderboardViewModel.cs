namespace Chessly.Web.ViewModels
{
    public class LeaderboardViewModel
    {
        public int Rank { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int Elo { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int TotalGames => Wins + Losses + Draws;
        public double WinRate => TotalGames > 0 ? Math.Round((double)Wins / TotalGames * 100, 1) : 0.0;
    }
}
