using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.MODEL.Models
{
    public class ProjectMembersResponseModel
    {

        [Display(Name = "Project ID :")]
        public int projectId { get; set; }
        [Display(Name = "Employee ID :")]
        public int employeeId { get; set; }
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

    }
}
