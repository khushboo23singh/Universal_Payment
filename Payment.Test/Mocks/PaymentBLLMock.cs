using Payment.BLL;
using Payment.Models;
using System;
using System.Collections.Generic;

namespace Payment.Test.Mocks
{
    public class PaymentBLLMock : IPaymentBLL
    {
        public int? CheckNumber(long MobileNumber, string Operator)
        {
            throw new NotImplementedException();
        }

        public List<PrePaidModel> Display(string MobileOperator)
        {
            throw new NotImplementedException();
        }

        public int? ForgotPasswordRegister(RegisterModel modelObj)
        {
            throw new NotImplementedException();
        }

        public int? LoginCustomer(LoginModel loginobj)
        {
            throw new NotImplementedException();
        }

        public int? LoginVerify(long MobileNumber)
        {
            throw new NotImplementedException();
        }



        public Receipt MakePayment(PaymentModel paymentModel, ServiceProviderType serviceProviderType, IBill bill)
        {
            return new Receipt()
            {
                ReceiptId = (new Random()).Next(),
                ReceiptNo = "12df",
                ReceiptAmount = 23,
                GeneratedDate = DateTime.Today,
                Customer = new Customer()
            };
        }

        public int? PostPaid(PostPaidModel postobj)
        {
            throw new NotImplementedException();
        }

        public int? RegisterCustomerData(RegisterModel Registerobj)
        {
            throw new NotImplementedException();
        }
    }
}
