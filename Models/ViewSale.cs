using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class ViewSale
    {
        public string SalesId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public string UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string SoldBy { get; set; }
        public DateTime? SellingDate { get; set; }
        public string Product { get; set; }
        public string StockProductName { get; set; }
        public decimal? ProductSellingPrice { get; set; }
        public decimal? ProductPurchasePrice { get; set; }
        public decimal? QuantityAvailable { get; set; }
        public string SalesUnitName { get; set; }
        public string ProductsUnitName { get; set; }
        public string StockProductId { get; set; }
        public decimal? QuantityRemaining { get; set; }
        public decimal? MoneyReceived { get; set; }
        public decimal? BalanceReturned { get; set; }
    }
}
