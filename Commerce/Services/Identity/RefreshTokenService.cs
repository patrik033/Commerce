using Commerce.Data;
using Commerce.Models.Identity.DTOIdentity;
using Commerce.Services.Identity.Token;
using Commerce.Utility;
using System.Net;

namespace Commerce.Services.Identity
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private readonly ApiResponse _response;
        private readonly AppDbContext _context;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;

        public RefreshTokenService(IHttpContextAccessor contextAccessor,IConfiguration configuration,AppDbContext context, ITokenService tokenService)
        {
            _contextAccessor = contextAccessor;
            _configuration = configuration;
            _tokenService = tokenService;
            _context = context;
            _response = new ApiResponse();
        }


    
        public async Task<ApiResponse> RefreshToken(TokenApiModel tokenApiModel)
        {

            var secretKey = _configuration.GetValue<string>("ApiSettings:Secret");

            if (tokenApiModel is null)
            {
                ResponseResult(HttpStatusCode.BadRequest, false, "Invalid client request", "");
                return _response;
            }


            string accessToken = tokenApiModel.AccessToken;
            string refreshToken = tokenApiModel.RefreshToken;

            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken,secretKey);
            //var username =   principal.Identity.Name; //this is mapped to the Name claim by default
            var username = tokenApiModel.UserName;
            var user = _context.ApplicationUsers.SingleOrDefault(u => u.UserName == username);
            
            
            if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                ResponseResult(HttpStatusCode.BadRequest, false, "Invalid client request", "");
                return _response;
            }
  


            var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims,secretKey);
            var newRefreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshToken = newRefreshToken;

            await _context.SaveChangesAsync();

            var httpContext = _contextAccessor.HttpContext;

            var result = new AuthenticatedResponse
            {
                Token = newAccessToken,
                RefreshToken = newRefreshToken,
            };


            var result2 = new LoginResponseDTO
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken,
                Email = user.Email,
            };



            _tokenService.SetTokensInsideCookie(result2, httpContext);


            ResponseResult(HttpStatusCode.OK,true,"", result);
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
