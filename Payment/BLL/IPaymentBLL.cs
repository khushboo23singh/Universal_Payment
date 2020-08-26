using System.Collections.Generic;
using Payment.Models;

namespace Payment.BLL
{
    public interface IPaymentBLL
    {
        int? CheckNumber(long MobileNumber, string Operator);
        List<PrePaidModel> Display(string MobileOperator);
        int? ForgotPasswordRegister(RegisterModel modelObj);
        int? LoginCustomer(LoginModel loginobj);
        int? LoginVerify(long MobileNumber);
        Receipt MakePayment(PaymentModel paymentModel, ServiceProviderType serviceProviderType, IBill bill);
        int? PostPaid(PostPaidModel postobj);
        int? RegisterCustomerData(RegisterModel Registerobj);
    }
}