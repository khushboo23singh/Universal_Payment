using System;

namespace Payment.BLL
{
    public class AirtellService : IService
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ServiceAddress { get; set; }

        public IBill GenerateReceipt(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Receipt GenerateReceipt(IBill Bill)
        {
            throw new NotImplementedException();
        }
    }
}