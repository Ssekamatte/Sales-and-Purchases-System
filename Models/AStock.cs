using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AStock
    {
        public AStock()
        {
            AProducts = new HashSet<AProduct>();
            AStockLogs = new HashSet<AStockLog>();
            Sales = new HashSet<Sale>();
        }

        public string StockProductId { get; set; }
        public string StockProductName { get; set; }
        public string UnitId { get; set; }
        public decimal? QuantityAvailable { get; set; }
        public decimal? QuantitySold { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual AUnit Unit { get; set; }
        public virtual ICollection<AProduct> AProducts { get; set; }
        public virtual ICollection<AStockLog> AStockLogs { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
