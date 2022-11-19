using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zip.InstallmentsModel;

namespace Zip.InstallmentsIRepository
{
    public interface IPaymentPlanRepository
    {
        PaymentPlan CreatePaymentPlan(PaymentPlan oPaymentPlan);
    }
}
