using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMP.Common
{
    public enum EmployeeRole
    {
        [Display(Name ="Project Manager")]
        ProjectManager = 1,
        [Display(Name ="Senior Developer")]
        SeniorDeveloper,
        [Display(Name = "Junior Developer")]
        JuniorDeveloper
    }

    public enum Department
    {
        Admin = 1,
        Manager,
        Employee
    }

    public enum technology
    {
        [Display(Name ="Microsoft Tech")]
        MSTech = 1,
        Java,
        Python,
    }

    public class ELibrary
    {
        
    }
}
