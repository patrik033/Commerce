using Commerce.Models.Identity.DTOIdentity;
using Commerce.Utility;
using Microsoft.AspNetCore.Mvc;


namespace Commerce.Services.Identity
{
    public interface IUserLoginService
    {
        Task<ApiResponse> LoginUserAsync(LoginModel loginRequestDTO);
    }
}
