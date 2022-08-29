using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.MODEL.Models
{
    public class ProjectMembersRequestModel
    {
        [Required]
        [Display(Name ="Project ID :")]
        public int projectId { get; set; }
        [Required]
        [Display(Name = "Employee ID :")]
        public int employeeId { get; set; }
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

    }
}
