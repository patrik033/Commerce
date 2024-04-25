using Commerce.Data;
using Commerce.Models.Identity.DTOIdentity;
using Commerce.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Commerce.Services.Identity
{
    public class RevokeTokenService : IRevokeToken
    {
        private readonly AppDbContext _context;
        private readonly ApiResponse _response;

        public RevokeTokenService(AppDbContext context)
        {
            _context = context;
            _response = new ApiResponse();
        }

        public async Task<ApiResponse> RevokeTokenAsync(LoginModel loginModel)
        {
           var user = await _context.ApplicationUsers.SingleOrDefaultAsync(x => x.UserName == loginModel.UserName);
            if ( user is null)
            {
                ResponseResult(HttpStatusCode.BadRequest, false, "", "");
                return _response;
            }

            user.RefreshToken = null;
            await _context.SaveChangesAsync();

            ResponseResult(HttpStatusCode.NoContent, true, "", "");
            return _response;
        } 

        private void ResponseResult(HttpStatusCode statusCode, bool successResult, string errorMessage, object apiResult)
        {
            _response.StatusCode = statusCode;
            _response.IsSuccess = successResult;
            _response.ErrorMessages.Add(errorMessage);
            _response.Result = apiResult;
        }
    }
}
