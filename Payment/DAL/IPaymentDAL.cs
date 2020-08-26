using System.Collections.Generic;
using Payment.Models;

namespace Payment.DAL
{
    public interface IPaymentDAL
    {
        int? CheckNumber(long MobileNumber, string Operator);
        List<PrePaidModel> Display(string MobileOperator);
        int? ForgotPasswordRegister(RegisterModel modelobj);
        int? LoginCustomer(LoginModel loginobj);
        int? LoginVerify(long MobileNumber);
        int? MakePayment(PaymentModel paymentModel);
        int? NetBanking(PaymentModel modelobj);
        int? PaymentCreditCard(PaymentModel modelobj);
        int? PostPaid(PostPaidModel postobj);
        int? RegisterCustomerData(RegisterModel registerObj);
    }
}