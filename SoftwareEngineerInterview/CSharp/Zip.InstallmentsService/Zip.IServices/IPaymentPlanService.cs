using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zip.InstallmentsModel;

namespace Zip.InstallmentsIService
{
    public interface IPaymentPlanFactory
    {
        string CreatePaymentPlan(string orderNumber,decimal purchaseAmount, int period = 1, int paymentFrequency = 14);
    }
}
