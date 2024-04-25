using Commerce.Models.Identity.DTOIdentity;
using Commerce.Models.Identity;
using Commerce.Services.Identity;
using Commerce.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Commerce.Services.Identity.Token;

namespace Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _context;
        //private readonly ILogger<Authentication> _logger;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly IUserLoginService _userLoginService;
        private readonly IConfirmAccountService _confirmAccountService;
        private readonly IUpdateAccount _updateAccount;
        private readonly IResetService _resetService;
        private readonly IRefreshTokenService _refreshToken;
        private readonly IRevokeToken _revokeToken;
        private readonly IConfiguration _configuration;

        public IdentityController
            (
            UserManager<ApplicationUser> userManager,
           // ILogger<Authentication> logger,
            IUserRegistrationService userRegistrationService,
            IUserLoginService userLoginService,
            IConfirmAccountService confirmAccountService,
            IUpdateAccount updateAccount,
            IResetService resetService,
            IRefreshTokenService refreshToken,
            IRevokeToken revokeToken, 
            IConfiguration configuration,
            AppDbContext context
            )
        {
            _context = context;
            _userRegistrationService = userRegistrationService;
            _userLoginService = userLoginService;
            _confirmAccountService = confirmAccountService;
            _updateAccount = updateAccount;
            _resetService = resetService;
            _userManager = userManager;
            _refreshToken = refreshToken;
            _revokeToken = revokeToken;
            //_logger = logger;
            _configuration = configuration;

        }

        [HttpPost]
        [Route("register")]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 500)]
        [AllowAnonymous]

        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            var result = await _userRegistrationService.RegisterUserAsync(registerRequestDTO);
            return StatusCode((int)result.StatusCode, result);
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(typeof(ApiResponse), 401)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [ProducesResponseType(typeof(ApiResponse), 403)]
        [ProducesResponseType(typeof(ApiResponse), 200)]

        public async Task<IActionResult> Login([FromBody] LoginModel loginRequestDTO)
        {
            var result = await _userLoginService.LoginUserAsync(loginRequestDTO);
            return StatusCode((int)result.StatusCode, result);
        }

        [HttpPost]
        [Route("refresh")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> RefreshToken([FromBody] TokenApiModel tokenApiModel)
        {
            var result = await _refreshToken.RefreshToken(tokenApiModel);
            return StatusCode((int)result.StatusCode, result);
        }
        [HttpPost]
        //[Authorize]
        [Route("revoke")]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [ProducesResponseType(typeof(ApiResponse), 204)]
        public async Task<IActionResult> RevokeToken([FromBody] LoginModel loginModel)
        {
            var result = await _revokeToken.RevokeTokenAsync(loginModel);
            return StatusCode((int)result.StatusCode);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("confirm")]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 403)]
        [ProducesResponseType(typeof(ApiResponse), 500)]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string email, [FromQuery] string activationToken)
        {
            var result = await _confirmAccountService.ConfirmEmail(email, activationToken);
            return StatusCode((int)result.StatusCode, result);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("resendConfirm")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 401)]

        public async Task<IActionResult> ResendConfirmEmail([FromBody] ResendRequestAgain email)
        {
            var result = await _confirmAccountService.ResendEmailActivationLink(email);
            return StatusCode((int)result.StatusCode, result);
        }

        [Authorize]
        [HttpPost]
        [Route("updatePassword")]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        [ProducesResponseType(typeof(ApiResponse), 404)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 500)]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordRequestDTO password)
        {
            var result = await _updateAccount.UpdatePassword(password);
            return StatusCode((int)result.StatusCode, result);
        }

        [Authorize]
        [HttpPost]
        [Route("updateName")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 409)]
        [ProducesResponseType(typeof(ApiResponse), 404)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> UpdateName([FromBody] UpdateNameRequestDTO name)
        {
            var result = await _updateAccount.UpdateName(name);
            return StatusCode((int)result.StatusCode, result);
        }

        [Authorize]
        [HttpPost]
        [Route("updateEmail")]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 409)]
        [ProducesResponseType(typeof(ApiResponse), 404)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> UpdateEmail([FromBody] UpdateEmailRequestDTO email)
        {
            var result = await _updateAccount.UpdateEmail(email);
            return StatusCode((int)result.StatusCode, result);
        }

        [HttpPost]
        [Route("resend")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDTO forgotPassword)
        {
            var result = await _resetService.ForgotPassword(forgotPassword);
            return StatusCode((int)result.StatusCode, result);
        }

        [HttpGet]
        [Route("confirmPasswordReset")]
        public async Task<IActionResult> ConfirmPasswordReset([FromQuery] string email, [FromQuery] string password, [FromQuery] string activationToken)
        {
            var result = await _resetService.ConfirmPasswordReset(email, password, activationToken);
            return StatusCode((int)result.StatusCode, result);
        }

        [HttpGet]
        [Route("user")]
        public async Task<IActionResult> GetUser([FromQuery] string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                return Ok(user.Id);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("address/{userName}")]
        public async Task<IActionResult> GetAddress(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                var address = await _context.Users
                    .Where(x => x.Id == user.Id)
                    .Include(x => x.Address) // Directly select the Address entity
                    .Select(x => new
                    {
                        StreetNumber = x.Address.StreetNumber,
                        StreetAddress = x.Address.StreetAddress,
                        City = x.Address.City,
                        ZipCode = x.Address.ZipCode
                    })
                    .FirstOrDefaultAsync();

                if (address != null)
                    return Ok(address);

                return NotFound();
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("addAddress")]
        public async Task<IActionResult> AddAddress([FromBody] AddressRequest addressRequest)
        {
            var user = await _userManager.FindByNameAsync(addressRequest.UserId);

            if (user != null)
            {
                user.Address = new Address
                {
                    StreetAddress = addressRequest.StreetAddress,
                    City = addressRequest.City,
                    ZipCode = addressRequest.ZipCode,
                    UserId = user.Id
                };

                _context.Addresses.Add(user.Address);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();
        }
    }
}
