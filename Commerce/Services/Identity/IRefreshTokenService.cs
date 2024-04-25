using Commerce.Models.Identity.DTOIdentity;
using Commerce.Utility;

namespace Commerce.Services.Identity
{
    public interface IRefreshTokenService
    {
         Task<ApiResponse> RefreshToken(TokenApiModel tokenApiModel);
    }
}
