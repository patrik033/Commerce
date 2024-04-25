namespace Commerce.Models.Identity.DTOIdentity
{
    public class UpdateNameRequestDTO
    {
        public string UserId { get; set; }
        public string OldName { get; set; }
        public string NewName { get; set; }

    }
}
