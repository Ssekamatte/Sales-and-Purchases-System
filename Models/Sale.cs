using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SalesLogs = new HashSet<SalesLog>();
        }

        public string SalesId { get; set; }
        public string Product { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityRemaining { get; set; }
        public decimal? Amount { get; set; }
        public string UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? MoneyReceived { get; set; }
        public decimal? BalanceReturned { get; set; }
        public string SoldBy { get; set; }
        public DateTime? SellingDate { get; set; }

        public virtual AStock Product1 { get; set; }
        public virtual AProduct ProductNavigation { get; set; }
        public virtual AUnit Unit { get; set; }
        public virtual ICollection<SalesLog> SalesLogs { get; set; }
    }
}
