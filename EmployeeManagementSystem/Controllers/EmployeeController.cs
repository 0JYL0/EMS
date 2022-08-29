using EMS.BAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee employee;
        private readonly IProject project;
        public EmployeeController(IProject project, IEmployee employee)
        {
            this.employee = employee;
            this.project = project;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employeeId = HttpContext.Session.GetString("EmployeeId");
            var department = HttpContext.Session.GetString("Department");

            if (employeeId == null || department != "3")
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
                int id = Int32.Parse(employeeId);
                var employeeDetail = employee.GetEmployeeDetailsById(id);
                ViewBag.EmployeeId = employeeId;
                return View(employeeDetail);
            }     
        }
    }
}
