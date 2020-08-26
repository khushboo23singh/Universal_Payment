using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payment.Controllers;
using Payment.Test.Mocks;
using System;

namespace Payment.Test
{
    [TestClass]
    public class PaymentApiTest

    {
        private PaymentController paymentController;
        [TestInitialize]
        public void Initiate()
        {
            this.paymentController = new PaymentController(new PaymentBLLMock());
        }

        [TestMethod]
        public void TestMakePayment()
        {
            var builder = new Builder.PaymentModelBuilder();
            var model = builder.WithTestValues()
                .CardNumber(12345353435635)
                .Build();
            var bill = new BLL.BescomBill()
            { BillId = (new Random()).Next(),
            BillAmount = 100,
            BillNo = "23d",
            Customer = new BLL.Customer(),
            DueDate = DateTime.Today.Add(TimeSpan.FromDays(3)),
            GeneratedDate = DateTime.Today,
            ServiceName = BLL.ServiceProviderType.Electicity.ToString()
            };

           var result = this.paymentController.MakePayment(model, BLL.ServiceProviderType.Electicity, bill);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.StatusCode == System.Net.HttpStatusCode.OK);
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            this.paymentController = null;
        }
    }
}
