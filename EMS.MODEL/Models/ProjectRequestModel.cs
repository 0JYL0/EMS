using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.MODEL.Models
{
    public class ProjectRequestModel
    {

        public int projectId { get; set; }
        [Required]
        [Display(Name = "Project Name :")]
        public string projectName { get; set; }
        [Required]
        [Display(Name = "Project Description :")]
        public string projectDescription { get; set; }
        [Required]
        [Display(Name = "Project Tech :")]
        public int projectTech { get; set; }
        [Required]
        [Display(Name = "Start Date :")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date :")]
        public DateTime EndDate { get; set; }

    }
}
