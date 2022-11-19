using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zip.InstallmentsIRepository;
using Zip.InstallmentsModel;

namespace Zip.InstallmentRepository
{
    public class PaymentPlanRepository : IPaymentPlanRepository
    {
        private IPaymentPlanRepository oPaymentPlanRepo;
        public PaymentPlanRepository(IPaymentPlanRepository paymentPlanRepo) { 
            oPaymentPlanRepo= paymentPlanRepo;
        }
        public PaymentPlan CreatePaymentPlan(PaymentPlan oPaymentPlan)
        {
            PaymentPlansList.Add(oPaymentPlan);
            return oPaymentPlan;
        }


        public List<PaymentPlan> PaymentPlansList=new List<PaymentPlan>();
    }
}
