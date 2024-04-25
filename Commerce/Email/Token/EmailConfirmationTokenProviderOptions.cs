using Microsoft.AspNetCore.Identity;

namespace Commerce.Email.Token
{
    public class EmailConfirmationTokenProviderOptions : DataProtectionTokenProviderOptions
    {
        public EmailConfirmationTokenProviderOptions()
        {
            Name = "EmailDataProtectorTokenProvider";
            TokenLifespan = TimeSpan.FromMinutes(60);
        }
    }
}
