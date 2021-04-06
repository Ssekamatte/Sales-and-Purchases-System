using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AProductLog
    {
        public string ProductLogId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string BrandId { get; set; }
        public string CategoryId { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? ProductSellingPrice { get; set; }
        public decimal? ProductPurchasePrice { get; set; }
        public decimal? Quantity { get; set; }
        public string UnitId { get; set; }
        public string PurchasedBy { get; set; }
        public string SoldBy { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? SellingDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual AProduct Product { get; set; }
    }
}
