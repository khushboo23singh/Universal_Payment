using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Payment.DAL;
using Payment.Models;

namespace Payment.BLL
{
    public class PaymentBLL : IPaymentBLL
    {
        IPaymentDAL paymentDAL;
        IServiceProviderFactory serviceProviderFactory;

        public PaymentBLL()
        {
            paymentDAL = new PaymentDAL();
             serviceProviderFactory = new ServiceProviderFactory();
        }

        public PaymentBLL(IPaymentDAL paymentDAL, IServiceProviderFactory serviceProviderFactory)
        {
            this.paymentDAL = paymentDAL;
            this.serviceProviderFactory = serviceProviderFactory;


        }

        public Receipt MakePayment(PaymentModel paymentModel, ServiceProviderType serviceProviderType, IBill bill)
        {
            
            IServiceProvider serviceProvider = serviceProviderFactory.GetServiceProvider(serviceProviderType);
            IService service = serviceProvider.GetService(bill.ServiceName);
            var payment = paymentDAL.MakePayment(paymentModel);
            if (payment.Value > 0)
                return service.GenerateReceipt(bill);
            else
                throw new Exception("Payment failure.");
        }       

        public int? RegisterCustomerData(RegisterModel Registerobj)
        {
            return paymentDAL.RegisterCustomerData(Registerobj); 
        }
        public int? LoginCustomer(LoginModel loginobj)
        {
            return paymentDAL.LoginCustomer(loginobj); ;
        }

        public List<PrePaidModel> Display(string MobileOperator)
        {
            return paymentDAL.Display(MobileOperator);
        }

        public int? PostPaid(PostPaidModel postobj)
        {
            return paymentDAL.PostPaid(postobj);
        }
        public int? CheckNumber(long MobileNumber,string Operator)
        {
            return paymentDAL.CheckNumber(MobileNumber, Operator);
        }

        public int? ForgotPasswordRegister(RegisterModel modelObj)
        {
            return paymentDAL.ForgotPasswordRegister(modelObj);
        }
        public int? LoginVerify(long MobileNumber)
        {
            return paymentDAL.LoginVerify(MobileNumber);
        }
    }
}