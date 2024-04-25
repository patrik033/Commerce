namespace Commerce.Models.Identity.DTOIdentity
{
    public class LoginResponseDTO
    {
        public string? Email { get; set; }
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }

    }
}
