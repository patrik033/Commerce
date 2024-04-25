using Commerce.Models.Identity.DTOIdentity;
using Commerce.Utility;
using Microsoft.AspNetCore.Mvc;


namespace Commerce.Services.Identity
{
    public interface IUpdateAccount
    {
        Task<ApiResponse> UpdateName([FromBody] UpdateNameRequestDTO name);
        Task<ApiResponse> UpdateEmail([FromBody] UpdateEmailRequestDTO email);
        Task<ApiResponse> UpdatePassword([FromBody] UpdatePasswordRequestDTO password);
    }
}
