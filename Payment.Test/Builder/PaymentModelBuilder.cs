using Payment.Models;
using System.Collections.Generic;

namespace Payment.Test.Builder
{
    public class PaymentModelBuilder
    {
        PaymentModel _entity = new PaymentModel();

        public PaymentModelBuilder CardNumber(long cardNumber)
        {
            _entity.CardNumber = cardNumber;
            return this;
        }
        public PaymentModelBuilder CVVNumber(int cVVNumber)
        {
            _entity.CVVNumber = cVVNumber;
            return this;
        }
        public PaymentModelBuilder WithTestValues()
        {
            _entity = new PaymentModel()
            {
                CardNumber = 1234567890123456,
                CVVNumber = 123,
                ExpiryDate = "0609",
                AccountHolderName = "Test",
                BankName = "ABC",
                UserID = "abc",
                Balance = 1234,
                Amount = 123,
                PaymentMethod = Utilities.PaymentMethods.CREDITCARD,
                paymentlist = new List<PaymentModel>(),
            };
            return this;
        }

        public PaymentModel Build()
        {
            return _entity;
        }
    }
}
