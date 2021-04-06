using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AUnit
    {
        public AUnit()
        {
            AProducts = new HashSet<AProduct>();
            AStocks = new HashSet<AStock>();
            Sales = new HashSet<Sale>();
        }

        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<AProduct> AProducts { get; set; }
        public virtual ICollection<AStock> AStocks { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
