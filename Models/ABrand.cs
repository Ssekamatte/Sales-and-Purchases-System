using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class ABrand
    {
        public ABrand()
        {
            AProducts = new HashSet<AProduct>();
        }

        public string BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<AProduct> AProducts { get; set; }
    }
}
