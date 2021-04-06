using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class ACategory
    {
        public ACategory()
        {
            AProducts = new HashSet<AProduct>();
        }

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<AProduct> AProducts { get; set; }
    }
}
