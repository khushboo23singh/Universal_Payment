using System;

namespace Payment.BLL
{
    public interface IBill
    {
        string ServiceName { get; set; }
        int BillId { get; set; }
        string BillNo { get; set; }
        DateTime DueDate { get; set; }
        decimal BillAmount { get; set; }
        DateTime GeneratedDate { get; set; }

        Customer Customer { get; set; }

    }
}