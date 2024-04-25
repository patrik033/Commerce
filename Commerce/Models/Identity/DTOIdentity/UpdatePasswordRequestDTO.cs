namespace Commerce.Models.Identity.DTOIdentity
{
    public class UpdatePasswordRequestDTO
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string RepeatedPassword { get; set; }
        public string UserId { get; set; }
    }
}
