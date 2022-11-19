using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zip.InstallmentsAPI.ViewModel;
using Zip.InstallmentsIRepository;
using Zip.InstallmentsIService;

namespace Zip.InstallmentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentPlan : ControllerBase
    {
        private IPaymentPlanFactory oPaymntPlanServ;
        private IPaymentPlanRepository oPaymntPlanRepo;
        public PaymentPlan(IPaymentPlanFactory paymntPlanServ, IPaymentPlanRepository oRepo)
        {
            oPaymntPlanServ= paymntPlanServ;
            oPaymntPlanRepo= oRepo;
        }

        [HttpPost]
        [Route("CreatePaymentPlan")]
        public IActionResult CreatePaymentPlan(vPaymentPlan paymentPlan)
        {
           string sTransactionId= oPaymntPlanServ.CreatePaymentPlan(paymentPlan.OrderNumber, paymentPlan.PurchaseAmount, paymentPlan.InstallmentPeriod);
            return Ok(sTransactionId);
        
        }

    }
}
