

using Commerce.Email.Azure;
using Commerce.Models.Email;


namespace Commerce.Services.Email
{
    public class EmailRegistrationSuccessfullConsumer
    {
        private readonly ISendGridEmailRegisterService _sendGridEmailRegisterService;
        private readonly AzureKeyVault _azureKeyVaultKey;
        public EmailRegistrationSuccessfullConsumer(ISendGridEmailRegisterService sendGridEmailRegisterService, AzureKeyVault azureKeyVaultKey)
        {
            _sendGridEmailRegisterService = sendGridEmailRegisterService;
            _azureKeyVaultKey = azureKeyVaultKey;
        }

        public async Task Consume(EmailConfirmationMessage context)
        {
            var data = context;
            var sendGridKey = await _azureKeyVaultKey.GetSendgridSecretAsync();
            var from = await _azureKeyVaultKey.GetSenderEmailSecretAsync();

            if (data != null && sendGridKey != null && from != null)
            {
                var result = await _sendGridEmailRegisterService.SendAsync(from, data.Email, "Confirm your email", data.EmailToken, data.UserName);
            }
        }
    }
}
