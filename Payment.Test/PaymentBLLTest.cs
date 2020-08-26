using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.BLL;
using Payment.DAL;
using Payment.Models;
using Moq;

namespace Payment.Test
{
    class PaymentBLLTest
    {
        private PaymentBLL paymentBLL;
       

        [TestMethod]
        public void TestMakePayment()
        {
            var builder = new Builder.PaymentModelBuilder();
            var model = builder.WithTestValues()
                .CardNumber(12345353435635)
                .Build();

            var bill = new BescomBill()
            {
                BillId = (new Random()).Next(),
                BillAmount = 100,
                BillNo = "23d",
                Customer = new Customer(),
                DueDate = DateTime.Today.Add(TimeSpan.FromDays(3)),
                GeneratedDate = DateTime.Today,
                ServiceName = ServiceProviderType.Electicity.ToString()
            };

            Mock<IPaymentDAL> mock = new Mock<IPaymentDAL>();
            mock.Setup(e => e.MakePayment(model)).Returns(1);


            this.paymentBLL = new PaymentBLL(mock.Object,new ServiceProviderFactory());

           
            var result = this.paymentBLL.MakePayment(model,ServiceProviderType.Electicity,bill);

            Assert.IsNotNull(result);
          
        }
       
    }
}
