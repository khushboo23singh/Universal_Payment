using System;

namespace Payment.BLL
{
    public class ServiceProviderFactory : IServiceProviderFactory
    {
        public IServiceProvider GetServiceProvider(ServiceProviderType ProviderType)
        {
            switch (ProviderType)
            {
                case ServiceProviderType.Electicity:
                    return new ElectricityServiceProvider();
                case ServiceProviderType.Mobile:
                    return new MobileServicProvider();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}