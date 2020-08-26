namespace Payment.BLL
{
    public interface IServiceProviderFactory
    {
        IServiceProvider GetServiceProvider(ServiceProviderType ProviderType);
    }
}