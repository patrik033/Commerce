using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commerce.Models.Identity.DTOIdentity
{
    public class LoginModel
    {

        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
