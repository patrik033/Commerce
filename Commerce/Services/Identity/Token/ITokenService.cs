using Commerce.Models.Identity.DTOIdentity;
using System.Security.Claims;

namespace Commerce.Services.Identity.Token
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims, string key);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token, string key);
        void SetTokensInsideCookie(LoginResponseDTO tokenDto, HttpContext context);
    }
}
