using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EMS.DL
{
    public partial class EmployeeMapping
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Employee Manager { get; set; }
    }
}
