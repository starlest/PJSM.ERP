﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUJASM.ERP.Models.Purchase
{
    public class PurchaseReturnTransaction
    {
        public PurchaseReturnTransaction()
        {
            // ReSharper disable once VirtualMemberCallInContructor
            PurchaseReturnTransactionLines = new List<PurchaseReturnTransactionLine>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), Column(Order = 0), StringLength(128)]
        public string PurchaseReturnTransactionID { get; set; }

        public virtual PurchaseTransaction PurchaseTransaction { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal NetTotal { get; set; }

        public virtual User User { get; set; }

        public virtual List<PurchaseReturnTransactionLine> PurchaseReturnTransactionLines { get; set; }
    }
}
