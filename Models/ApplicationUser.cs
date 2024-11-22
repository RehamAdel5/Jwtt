using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JWtApi.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required, MaxLength(50)]
        public string FristName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public List<RefreshToken>? RefreshTokens { get; set; }

    }
}
