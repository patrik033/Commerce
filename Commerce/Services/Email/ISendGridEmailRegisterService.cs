using SendGrid;

namespace Commerce.Services.Email
{
    public interface ISendGridEmailRegisterService
    {
        Task<Response> SendAsync(string from, string to, string subject, string body, string name);
    }
}
