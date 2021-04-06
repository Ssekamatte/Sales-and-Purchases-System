using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AStockLog
    {
        public string StockLogId { get; set; }
        public string StockProductId { get; set; }
        public string StockProductName { get; set; }
        public string UnitId { get; set; }
        public decimal? QuantityAvailable { get; set; }
        public decimal? QuantitySold { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual AStock StockProduct { get; set; }
    }
}
