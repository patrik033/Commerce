using Microsoft.AspNetCore.Identity;

namespace Commerce.Password
{
    public class PasswordResetTokenProviderOptions : DataProtectionTokenProviderOptions
    {
        public PasswordResetTokenProviderOptions()
        {
            Name = "PasswordResetTokenProvider";
            TokenLifespan = TimeSpan.FromMinutes(5);
        }
    }
}
