using Commerce.Models.Identity.DTOIdentity;
using Commerce.Utility;
using Microsoft.AspNetCore.Mvc;


namespace Commerce.Services.Identity
{
    public interface IResetService
    {
        Task<ApiResponse> ForgotPassword([FromBody] ForgotPasswordDTO forgotPassword);
        Task<ApiResponse> ConfirmPasswordReset([FromQuery] string email, [FromQuery] string password, [FromQuery] string activationToken);
    }
}
