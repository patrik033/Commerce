﻿using SendGrid;

namespace Commerce.Email.Token
{
    public interface ISendGridEmailTokens
    {
        Task<Response> SendAsync(string from, string to, string subject, string tokenLink, string name);
    }
}
