using log4net;
using Payment.BLL;
using Payment.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Payment.Controllers
{
    public class PaymentController : ApiController
    {
        private readonly ILog  logger = LogManager.GetLogger(typeof(PaymentController));
        IPaymentBLL paymentBLL;


        public PaymentController(IPaymentBLL paymentBLL)
        {

            this.paymentBLL = paymentBLL;


        }
        public PaymentController()
        {

            this.paymentBLL = new PaymentBLL();
        }

        [HttpPost]

        public HttpResponseMessage MakePayment(PaymentModel model, ServiceProviderType serviceProviderType, IBill bill)
        {

            var receipt = paymentBLL.MakePayment(model, serviceProviderType,bill);
            return Request.CreateResponse(HttpStatusCode.OK, receipt);
        }

        [HttpPost]
        public int? Register(RegisterModel registerobj)
        {
            HttpResponseMessage message = new HttpResponseMessage();

            int? Result = paymentBLL.RegisterCustomerData(registerobj);

            if (Result > 0)
            {
                message.Content = new StringContent("SUCCESS");
            }
            else
            {
                message.Content = new StringContent("FAIL");
            }

            return Result;
        }
        int? Result1;



        [HttpPost]
        public int? Login(LoginModel loginobj)
        {
            HttpResponseMessage message = new HttpResponseMessage();

            int? Result = paymentBLL.LoginCustomer(loginobj);

            if (Result > 0)
            {
                Result1 = paymentBLL.LoginVerify(loginobj.MobileNumber);
                if (Result1 > 0)
                {
                    message.Content = new StringContent("LOGIN SUCCESS");
                }
                else
                {
                    message.Content = new StringContent("LOGIN PrePaid");

                }
            }
            else
            {
                message.Content = new StringContent("LOGIN FAIL");
                Result1 = -1;
            }
            return Result1;
        }

        [HttpGet]
        public List<PrePaidModel> GetDetails(string MobileOperator, long MobileNumber)
        {
            PrePaidModel modelObj = new PrePaidModel();

            int? result = this.paymentBLL.CheckNumber(MobileNumber, MobileOperator);
            if (result > 0)
            {
                modelObj.PrepaidList = this.paymentBLL.Display(MobileOperator);
            }

            return modelObj.PrepaidList;
        }
        [HttpPost]
        public int? PostPaid(PostPaidModel postobj)
        {
            HttpResponseMessage message = new HttpResponseMessage();

            int? Result = paymentBLL.PostPaid(postobj);

            if (Result > 0)
            {

                message.Content = new StringContent("LOGIN SUCCESS");
            }
            else
            {
                message.Content = new StringContent("LOGIN FAIL");
            }
            return Result;
        }

        [HttpPost]
        public int? ForgotPassword(RegisterModel model)
        {

            HttpResponseMessage message = new HttpResponseMessage();

            int? Result = paymentBLL.ForgotPasswordRegister(model);

            return Result;
        }
    }
}
