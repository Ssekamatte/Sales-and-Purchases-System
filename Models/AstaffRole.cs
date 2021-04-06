using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AstaffRole
    {
        public AstaffRole()
        {
            AStaffs = new HashSet<AStaff>();
        }

        public string StaffRoleId { get; set; }
        public string StaffRole { get; set; }

        public virtual ICollection<AStaff> AStaffs { get; set; }
    }
}
