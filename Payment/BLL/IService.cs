using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.BLL
{
    public interface IService
    {
        int ServiceId { get; set; }
        string ServiceName { get; set; }
        int ServiceAddress { get; set; }

        Receipt GenerateReceipt(IBill Bill);

    }


}