using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payment.BLL
{
    public class Receipt
    {
      public  int ReceiptId { get; set; }
        public string ReceiptNo { get; set; }
        public decimal ReceiptAmount { get; set; }
        public DateTime GeneratedDate { get; set; }

        public Customer Customer { get; set; }
    }
}