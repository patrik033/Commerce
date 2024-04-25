namespace Commerce.Models.Identity.DTOIdentity
{
    public class AuthenticatedResponse
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
    }
}
