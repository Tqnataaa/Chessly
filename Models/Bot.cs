using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Chessly.Web.Models
{
    public class Bot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Difficulty { get; set; } = "Easy";

        [Range(0, 5000)]
        public int Elo { get; set; } = 200;

        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(250)]
        public string ImageUrl { get; set; } = string.Empty;

        public ICollection<GameHistory> Matches { get; set; } = new List<GameHistory>();

    }
}
