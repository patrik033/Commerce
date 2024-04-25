using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

        public Address? Address { get; set; }
        public BillingAddress? BillingAddress { get; set; }
    }
}
