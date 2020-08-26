using System;

namespace Payment.BLL
{
    public class ElectricityServiceProvider : IServiceProvider
    {
        public IService GetService(String ElectricityServiceName)
        {
            switch (ElectricityServiceName.ToLower())
            {
                case "bescom":
                    return new Bescom();
                case "mtnl":
                    return new MTNL();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}