using EMP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.MODEL.Models
{
    public class EmployeeResponseModel
    {
        public int Id { get; set; }

        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }
        
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        
        [Display(Name = "Employee Address")]
        public string EmployeeAddress { get; set; }
        
        [Display(Name = "Employee Email")]
        public string EmployeeEmail { get; set; }
        
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        [Display(Name = "Joining Date")]
        public string EmployeeJoiningDate { get; set; }
        
        [Display(Name = "Years of Experience")]
        public string EmployeeExperience { get; set; }
        
        [Display(Name = "Technology")]
        public int Technology { get; set; }
        
        [Display(Name = "Role")]
        public int Role { get; set; }
        
        [Display(Name = "Department")]
        public int Department { get; set; }
        public string EmployeeStatus { get; set; }



    }
}
