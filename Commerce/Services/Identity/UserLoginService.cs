using Commerce.Data;
using Commerce.Models.Identity;
using Commerce.Models.Identity.DTOIdentity;
using Commerce.Services.Identity.Token;
using Commerce.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace Commerce.Services.Identity
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string _secretKey;
        private readonly IConfiguration _configuration;
        private readonly ApiResponse _response;
        private readonly ITokenService _tokenService;
        private readonly IHttpContextAccessor _contextAccessor;
        public UserLoginService(IHttpContextAccessor contextAccessor,ITokenService tokenService,IConfiguration config, AppDbContext context, UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _contextAccessor = contextAccessor;
            _tokenService = tokenService;
            _config = config;
            _context = context;
            _userManager = userManager;
            _configuration = configuration;
            _secretKey = _configuration.GetValue<string>("ApiSettings:Secret");
            _response = new ApiResponse();
        }

        public async Task<ApiResponse> LoginUserAsync(LoginModel loginRequestDTO)
        {
            

            if(loginRequestDTO is null)
            {
                ResponseResult(HttpStatusCode.BadRequest, false, "Invalid client request", "");
            }



            var secretKey = _config.GetValue<string>("ApiSettings:Secret");
            var user = _context.ApplicationUsers.FirstOrDefault(x => x.UserName.ToLower() == loginRequestDTO.UserName.ToLower());
            bool isValid = await _userManager.CheckPasswordAsync(user, loginRequestDTO.Password);





            if (!isValid)
            {
                ResponseResult(HttpStatusCode.Unauthorized, false, "Username or password was incorrect", "");
                return _response;
            }

            bool isConfirmed = await _userManager.IsEmailConfirmedAsync(user);

            if (!isConfirmed)
            {
                ResponseResult(HttpStatusCode.Forbidden, false, "You must confirm your account before you login!", "");
                return _response;
            }

            // Generate JWT token
            JwtSecurityTokenHandler tokenHandler = new();
            var roles = await _userManager.GetRolesAsync(user);
            byte[] key = Encoding.ASCII.GetBytes(_secretKey);

            // Add claims to the token

            var symmetricSecretKey = new SymmetricSecurityKey(key);
            var signingCredentials = new SigningCredentials(symmetricSecretKey, SecurityAlgorithms.HmacSha256);

            var claims = AddClaimsToToken(user, roles);

            var accessToken = _tokenService.GenerateAccessToken(claims, secretKey);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

            await _context.SaveChangesAsync();

            var tokenOptions = new JwtSecurityToken(
               issuer: "https://localhost:5001",
               audience: "https://localhost:5001",
               claims: claims,
               expires: DateTime.Now.AddMinutes(5),
               signingCredentials: signingCredentials
               );

            // Generate the actual token
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);


            var loginResponse = new LoginResponseDTO
            {
                Email = user.Email,
                AccessToken = tokenString,
                RefreshToken = refreshToken
            };

            var httpContext = _contextAccessor.HttpContext;


            _tokenService.SetTokensInsideCookie(loginResponse, httpContext);





            if (string.IsNullOrEmpty(loginResponse.Email) || string.IsNullOrEmpty(loginResponse.AccessToken))
            {
                ResponseResult(HttpStatusCode.BadRequest, false, "Username or password is incorrect", "");
                return _response;
            }



            ResponseResult(HttpStatusCode.OK, true, "", loginResponse);
            return _response;
        }

        private static List<Claim> AddClaimsToToken(ApplicationUser? user, IList<string> roles)
        {
            var claims = new List<Claim>
            {
                 new Claim("fullName", user.Name),
                 new Claim("id", user.Id.ToString()),
                 new Claim(ClaimTypes.Email, user.UserName.ToString()),
                 new Claim(ClaimTypes.Role, roles.FirstOrDefault())
            };

            return claims;
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
