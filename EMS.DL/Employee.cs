using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EMS.DL
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeMappingEmployee = new HashSet<EmployeeMapping>();
            EmployeeMappingManager = new HashSet<EmployeeMapping>();
            ProjectMembers = new HashSet<ProjectMembers>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeEmail { get; set; }
        public string Password { get; set; }
        public DateTime EmployeeJoiningDate { get; set; }
        public string EmployeeExperience { get; set; }
        public int Technology { get; set; }
        public int Role { get; set; }
        public int Department { get; set; }
        public string EmployeeStatus { get; set; }

        public virtual ICollection<EmployeeMapping> EmployeeMappingEmployee { get; set; }
        public virtual ICollection<EmployeeMapping> EmployeeMappingManager { get; set; }
        public virtual ICollection<ProjectMembers> ProjectMembers { get; set; }
    }
}
