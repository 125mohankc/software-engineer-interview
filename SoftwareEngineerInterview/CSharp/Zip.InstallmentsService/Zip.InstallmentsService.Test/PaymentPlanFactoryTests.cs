using Shouldly;
using Xunit;
using Zip.InstallmentsIService;

namespace Zip.InstallmentsService.Test
{
    public class PaymentPlanFactoryTests
    {
        IPaymentPlanFactory oService;
        public PaymentPlanFactoryTests(IPaymentPlanFactory service)
        {
            oService   = service;
        }

        [Fact]
        public void WhenCreatePaymentPlanWithValidOrderAmount_ShouldReturnValidPaymentPlan()
        {
           string sTransactionId= oService.CreatePaymentPlan("ORDNUM0101", 2000, 4, 14);
           Assert.NotNull(sTransactionId);
        }
    }
}
