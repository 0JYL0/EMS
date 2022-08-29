using EMP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.MODEL.Models
{
    public class EmployeeRequestModel
    {
        public int EmployeeId { get; set; }
        [Required]
        [Display(Name = "Employee Name :")]
        public string EmployeeName { get; set; }
        [Required]
        [Display(Name = "Employee Address :")]
        public string EmployeeAddress { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Employee Email:")]
        public string EmployeeEmail { get; set; }
        [Required]
        //[RegularExpression("",ErrorMessage =)]
        [Display(Name ="Password : ")]
        public string Password { get; set; }
        [Required]
        [Display(Name ="Joining Date : ")]
        public DateTime EmployeeJoiningDate { get; set; }
        [Required]
        [Display(Name ="Years of Experience : ")]
        public string EmployeeExperience { get; set; }
        [Required]
        [Display(Name ="Technology : ")]
        public int Technology { get; set; }
        [Required]
        [Display(Name ="Role : ")]
        public int Role { get; set; }
        [Display(Name = "Department : ")]
        public int Department { get; set; }
        public string EmployeeStatus { get; set; }


    }
}
