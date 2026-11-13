using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Chessly.Web.ViewModels
{
    public class GameDetailsEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;

        
        [StringLength(500)]
        public string? Notes { get; set; }

        [ReadOnly(true)]
        public string BotName { get; set; } = string.Empty;
        [ReadOnly(true)]
        public string? BotImageUrl { get; set; }
        [ReadOnly(true)]
        public int BotElo { get; set; }
        [ReadOnly(true)]
        public string Result { get; set; } = string.Empty;
        [ReadOnly(true)]
        public DateTime PlayedOn { get; set; }
        [ReadOnly(true)]
        public string? PgnMoves { get; set; }
    }
}
