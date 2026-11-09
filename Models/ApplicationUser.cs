namespace Chessly.Web.Models
{
    using Microsoft.AspNetCore.Identity;
        public class ApplicationUser : IdentityUser
        {
            public string Country { get; set; } = "Unknown";
            public int Elo { get; set; } = 800;
            public int Wins { get; set; } = 0;
            public int Losses { get; set; } = 0;
            public int Draws { get; set; } = 0;
            public string ProfileImageUrl { get; set; } = string.Empty;
    }
}
