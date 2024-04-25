namespace Commerce.Email.Azure
{
    public interface IAzureKey
    {
        Task Initialize(string keyVaultUrl);
    }
}
