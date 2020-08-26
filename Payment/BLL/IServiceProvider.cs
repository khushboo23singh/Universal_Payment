using System;

namespace Payment.BLL
{
    public interface IServiceProvider
    {
        IService GetService(String ServiceName );
    }
}