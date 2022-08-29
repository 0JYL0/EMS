using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.MODEL.Models
{
    public class EmployeeMappingRequestModel
    {

        [Display(Name = "Manager Id : ")]
        public int ManagerId { get; set; }
        [Display(Name = "Employee Id : ")]
        public int EmployeeId { get; set; }

    }
}
