using System;

namespace Payment.BLL
{
    public class MobileServicProvider : IServiceProvider
    {
        public IService GetService(String MobileServiceName)
        {
            switch (MobileServiceName.ToLower())
            {
                case "airtell":
                    return new AirtellService();
                case "vodafone":
                    return new VodafoneService();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}