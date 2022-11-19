﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip.InstallmentsModel
{
    /// <summary>
    /// Data structure which defines all the properties for an installment.
    /// </summary>
    public class Installment
    {
        /// <summary>
        /// Gets or sets the unique identifier for each installment.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the date that the installment payment is due.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the amount of the installment.
        /// </summary>
        public decimal Amount { get; set; }
    }
}
