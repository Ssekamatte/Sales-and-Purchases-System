using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AstaffImage
    {
        public string StaffId { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public byte[] StaffImage { get; set; }

        public virtual AStaff Staff { get; set; }
    }
}
