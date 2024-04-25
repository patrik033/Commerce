namespace Commerce.Models.Email
{
    public class EmailConfirmationMessage
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string EmailToken { get; set; }

    }
}
