using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class ViewPurchase
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? ProductSellingPrice { get; set; }
        public decimal? ProductPurchasePrice { get; set; }
        public decimal? Quantity { get; set; }
        public string QuantityDetails { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public string PurchasedBy { get; set; }
        public string SoldBy { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? SellingDate { get; set; }
        public decimal? ProfitorLoss { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string StockProductName { get; set; }
    }
}
