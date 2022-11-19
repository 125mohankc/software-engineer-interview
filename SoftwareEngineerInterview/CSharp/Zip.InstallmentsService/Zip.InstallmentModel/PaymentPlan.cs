using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip.InstallmentsModel
{
    /// <summary>
    /// Data structure which defines all the properties for a purchase installment plan.
    /// </summary>
    public class PaymentPlan
    {
        public Guid Id { get; set; }

        public string OrderNumber { get; set; }

        public decimal PurchaseAmount { get; set; }

        public List<Installment> Installments { get; set; }
    }
}
