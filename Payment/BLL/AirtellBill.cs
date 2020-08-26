using System;

namespace Payment.BLL
{
    public class AirtellBill : IBill
    {
        public int BillId { get; set; }
        public string BillNo { get; set; }
        public DateTime DueDate { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string ServiceName { get; set; }
        public Customer Customer { get; set; }
    }
}