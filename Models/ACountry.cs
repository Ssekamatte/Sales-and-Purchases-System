using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class ACountry
    {
        public ACountry()
        {
            AStaffs = new HashSet<AStaff>();
        }

        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<AStaff> AStaffs { get; set; }
    }
}
