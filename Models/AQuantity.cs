using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AQuantity
    {
        public AQuantity()
        {
            AStocks = new HashSet<AStock>();
            Sales = new HashSet<Sale>();
        }

        public int UnitId { get; set; }
        public string UnitName { get; set; }

        public virtual ICollection<AStock> AStocks { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
