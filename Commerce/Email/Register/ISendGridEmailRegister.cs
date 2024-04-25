
using SendGrid;

namespace Commerce.Email.Register
{
    public interface ISendGridEmailRegister
    {
        Task<Response> SendAsync(string from, string to, string subject, string body, string name);
    }
}
