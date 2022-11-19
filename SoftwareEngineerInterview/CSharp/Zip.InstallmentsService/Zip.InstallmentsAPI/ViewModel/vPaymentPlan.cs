namespace Zip.InstallmentsAPI.ViewModel
{
    public class vPaymentPlan
    {
        public string OrderNumber { get; set; }

        public decimal PurchaseAmount { get; set; }

        public int InstallmentPeriod { get; set; }

        public int PaymentFrequency { get; set; }   
    }
}
