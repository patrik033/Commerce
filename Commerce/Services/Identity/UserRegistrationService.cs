using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using AutoMapper;
using Commerce.Models.Identity;
using Commerce.Email.Register;
using Commerce.Utility;
using Commerce.Models.Identity.DTOIdentity;
using Commerce.Models.Email;
using Commerce.Services.Email;



namespace Commerce.Services.Identity
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<UserRegistrationService> _logger;
        private readonly ISendGridEmailRegister _sendGridEmailRegister;
        private ApiResponse _response;
        private readonly EmailRegistrationSuccessfullConsumer _emailRegistrationSuccessfullConsumer;
        private readonly IMapper _mapper;

        public UserRegistrationService(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<UserRegistrationService> logger,
            ISendGridEmailRegister sendGridEmailRegister,
            EmailRegistrationSuccessfullConsumer emailRegistrationSuccessfullConsumer,
            IMapper mapper)
        {
            _response = new ApiResponse();
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _sendGridEmailRegister = sendGridEmailRegister;
            _emailRegistrationSuccessfullConsumer = emailRegistrationSuccessfullConsumer;
            _mapper = mapper;
        }

        public async Task<ApiResponse> RegisterUserAsync(RegisterRequestDTO registerRequestDTO)
        {
            try
            {
                // Check if the username is already taken
                var existingUserByEmail = await _userManager.FindByEmailAsync(registerRequestDTO.Email);
                var existingUserByName = await _userManager.FindByNameAsync(registerRequestDTO.Email);
                if (existingUserByEmail != null || existingUserByName != null)
                {
                    ResponseResult(HttpStatusCode.BadRequest, false, "Username already exists.", "");
                    return _response;
                }

                // Create a new user
                ApplicationUser newUser = AddUser(registerRequestDTO);
                var result = await _userManager.CreateAsync(newUser, registerRequestDTO.Password);

                if (result.Succeeded)
                {
                    await EnsureRolesExistAsync();
                    var userRole = GetUserRole(registerRequestDTO.Role);
                    await _userManager.AddToRoleAsync(newUser, userRole);



                    var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                    var urlToken = Base64UrlEncoder.Encode(emailToken);
                    var token = $"http://localhost:5173/RegisterConfirmation?email={newUser.Email}&activationToken={urlToken}";

                    var emailConfirmationMessage = _mapper.Map<EmailConfirmationMessage>(newUser);
                    emailConfirmationMessage.UserId = newUser.Id;
                    emailConfirmationMessage.EmailToken = token;
                    await _emailRegistrationSuccessfullConsumer.Consume(emailConfirmationMessage);


                    ResponseResult(HttpStatusCode.OK, true, "", "Please check your email for the confirmition email.");
                    return _response;
                }

                else
                {
                    ResponseResult(HttpStatusCode.BadRequest, false, result.Errors.FirstOrDefault()?.Description, null);
                    return _response;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"An exception was thrown during user registration: {ex.Message}", ex);
                var errorMessage = "Internal Server Error";
                ResponseResult(HttpStatusCode.InternalServerError, false, errorMessage, "");
                return _response;
            }
        }

        private static ApplicationUser AddUser(RegisterRequestDTO registerRequestDTO)
        {
            var user = new ApplicationUser();

            if (registerRequestDTO.BillingCity == null || registerRequestDTO.BillingZipCode == null || registerRequestDTO.BillingStreetNumber == null || registerRequestDTO.BillingStreetAddress == null)
            {
                user.Name = registerRequestDTO.Email;
                user.UserName = registerRequestDTO.Email;
                user.Email = registerRequestDTO.Email;
                user.NormalizedEmail = registerRequestDTO.Email.ToUpper();
                user.NormalizedUserName = registerRequestDTO.Email;

                user.Address = new Address
                {
                    StreetAddress = registerRequestDTO.StreetAddress,
                    City = registerRequestDTO.City,
                    ZipCode = registerRequestDTO.ZipCode,
                    StreetNumber = registerRequestDTO.StreetNumber, 
                };
            }

            else
            {
                user.Name = registerRequestDTO.Email;
                user.UserName = registerRequestDTO.Email;
                user.Email = registerRequestDTO.Email;
                user.NormalizedEmail = registerRequestDTO.Email.ToUpper();
                user.NormalizedUserName = registerRequestDTO.Email;

                user.Address = new Address
                {
                    StreetAddress = registerRequestDTO.StreetAddress,
                    City = registerRequestDTO.City,
                    ZipCode = registerRequestDTO.ZipCode,
                    StreetNumber = registerRequestDTO.StreetNumber
                };
                user.BillingAddress = new BillingAddress
                {
                    StreetAddress = registerRequestDTO.BillingStreetAddress,
                    City = registerRequestDTO.BillingCity,
                    ZipCode = registerRequestDTO.BillingZipCode,
                    StreetNumber = registerRequestDTO.BillingStreetNumber
                };
            }

            return user;
        }

        private void ResponseResult(HttpStatusCode statusCode, bool successResult, string errorMessage, object apiResult)
        {
            _response.StatusCode = statusCode;
            _response.IsSuccess = successResult;
            _response.ErrorMessages.Add(errorMessage);
            _response.Result = apiResult;
        }


        private async Task EnsureRolesExistAsync()
        {
            if (!await _roleManager.RoleExistsAsync(StaticDetails.Role_Admin))
            {
                // Create roles in the database
                await _roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Admin));
                await _roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_User));
            }
        }

        private string GetUserRole(string requestedRole)
        {
            return requestedRole.ToLower() == StaticDetails.Role_Admin.ToLower()
                ? StaticDetails.Role_Admin
                : StaticDetails.Role_User;
        }
    }
}
