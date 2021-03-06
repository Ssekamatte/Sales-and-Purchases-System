using System;
using System.Collections.Generic;

#nullable disable

namespace Sales.Models
{
    public partial class AStaff
    {
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffRoleId { get; set; }
        public int? GenderId { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public string NationalityId { get; set; }
        public string Phone { get; set; }
        public string Tele { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string NinNumber { get; set; }
        public bool? IsActive { get; set; }

        public virtual ACountry Nationality { get; set; }
        public virtual AstaffRole StaffRole { get; set; }
        public virtual AstaffImage AstaffImage { get; set; }
    }
}
