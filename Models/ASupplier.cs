using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class ASupplier
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public int? SupplierTelephone { get; set; }
        public DateTime? ExpectedSupplyDate { get; set; }
        public DateTime? DateOrderPlaced { get; set; }
        public string OrderPlacedBy { get; set; }
        public string ProductId { get; set; }

        public virtual AProduct Product { get; set; }
    }
}
