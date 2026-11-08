using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chessly.Web.Models
{
    public class GameHistory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }

        [Required]
        public int BotId { get; set; }

        [ForeignKey(nameof(BotId))]
        public Bot? Bot { get; set; }

        [Required]
        [MaxLength(10)]
        public string Result { get; set; } = string.Empty;

        public DateTime PlayedOn { get; set; } = DateTime.UtcNow;

        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Notes { get; set; }

        public string? PgnMoves { get; set; }
    }
}
