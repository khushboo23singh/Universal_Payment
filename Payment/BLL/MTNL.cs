﻿using System;

namespace Payment.BLL
{
    public class MTNL : IService
    {
        public int ServiceId { get ; set ; }
        public string ServiceName { get; set; }
        public int ServiceAddress { get; set; }

       

        public Receipt GenerateReceipt(IBill Bill)
        {
            throw new NotImplementedException();
        }
    }
}