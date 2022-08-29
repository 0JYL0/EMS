using EMP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.MODEL.Models
{
    public class ProjectResponseModel
    {

        [Display(Name = "Project ID :")]
        public int ProjectId { get; set; }
        [Display(Name = "Project Name :")]
        public string ProjectName { get; set; }
        [Display(Name = "Project Description :")]
        public string ProjectDescription { get; set; }
        [Display(Name = "Project Tech :")]
        public technology ProjectTech { get; set; }
        [Display(Name = "Start Date :")]
        public string StartDate { get; set; }
        [Display(Name = "End Date :")]
        public string EndDate { get; set; }


    }
}
