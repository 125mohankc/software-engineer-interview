using System;
using Zip.InstallmentsIRepository;
using Zip.InstallmentsIService;
using Zip.InstallmentsModel;

namespace Zip.InstallmentsService
{
    /// <summary>
    /// This class is responsible for building the PaymentPlan according to the Zip product definition.
    /// </summary>
    public class PaymentPlanFactory : IPaymentPlanFactory
    {
        private IPaymentPlanRepository oPaymentPlanRepo;
        public PaymentPlanFactory(IPaymentPlanRepository paymentPlanRepo) {
            oPaymentPlanRepo = paymentPlanRepo;
        }
        /// <summary>
        /// Builds the PaymentPlan instance.
        /// </summary>
        /// <param name="purchaseAmount">The total amount for the purchase that the customer is making.</param>
        /// <returns>The PaymentPlan created with all properties set.</returns>
        public string CreatePaymentPlan(string orderNumber,decimal purchaseAmount,int period=1,int paymentFrequency=14)
        {
            Guid sTransactionId;
            try
            {
               sTransactionId=Guid.NewGuid();
               
               PaymentPlan oPaymentPlan= new PaymentPlan() { Id=sTransactionId,
               PurchaseAmount =purchaseAmount,
               OrderNumber= orderNumber,
               };

              decimal installmentAmount=purchaseAmount/period;
              DateTime oDt= DateTime.Now;
             
              for(int i=0;i<period;i++)
                {
                    if (i > 0) oDt= oDt.AddDays(paymentFrequency);
                    Installment oInst = new Installment()
                    {
                        Id = Guid.NewGuid(),
                        Amount = installmentAmount,
                        DueDate = oDt
                    };
                    oPaymentPlan.Installments.Add(oInst);
                }

              oPaymentPlanRepo.CreatePaymentPlan(oPaymentPlan);

            }
            catch
            {
                return "";
            }
            return sTransactionId.ToString();
        }
    }
}
