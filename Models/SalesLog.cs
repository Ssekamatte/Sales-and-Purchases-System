using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class SalesLog
    {
        public string SalesLogId { get; set; }
        public string SalesId { get; set; }
        public string Product { get; set; }
        public int? Quantity { get; set; }
        public double? Amount { get; set; }
        public string UnitId { get; set; }
        public double? UnitPrice { get; set; }
        public string PurchasedBy { get; set; }
        public string SoldBy { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? SellingDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Sale Sales { get; set; }
    }
}
