using Commerce.Models.Identity.DTOIdentity;
using Commerce.Utility;
using Microsoft.AspNetCore.Mvc;


namespace Commerce.Services.Identity
{
    public interface IConfirmAccountService
    {
        Task<ApiResponse> ConfirmEmail([FromQuery] string email, [FromQuery] string activationToken);
        Task<ApiResponse> ResendEmailActivationLink([FromBody] ResendRequestAgain email);
    }
}
