using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AProduct
    {
        public AProduct()
        {
            AProductLogs = new HashSet<AProductLog>();
            Sales = new HashSet<Sale>();
        }

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

        public virtual ABrand Brand { get; set; }
        public virtual ACategory Category { get; set; }
        public virtual AStock ProductNameNavigation { get; set; }
        public virtual AUnit Unit { get; set; }
        public virtual ICollection<AProductLog> AProductLogs { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
