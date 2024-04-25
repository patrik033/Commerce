using Commerce.Models.Identity.DTOIdentity;
using Commerce.Utility;

namespace Commerce.Services.Identity
{
    public interface IRevokeToken
    {
        Task<ApiResponse> RevokeTokenAsync(LoginModel loginModel);
    }
}
