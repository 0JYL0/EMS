using EMS.BAL.Interface;
using EMS.MODEL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class AuthenticateController : Controller
    {
        private readonly IEmployee employee;
        public AuthenticateController(IEmployee employee)
        {
            this.employee = employee;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AuthRequestModel authRequest)
        {
            var ValidateUser = employee.AuthenticateUser(authRequest);
            HttpContext.Session.SetString("EmployeeId", ValidateUser.EmployeeId.ToString());
            HttpContext.Session.SetString("Department", ValidateUser.Department.ToString());

            if (ValidateUser.Department == 1)
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (ValidateUser.Department == 2)
            {
                return RedirectToAction("Index", "Manager");
            }
            else if(ValidateUser.Department == 3)
            {
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                ViewBag.ErrorMsg = "Invalid username and password !";
                return View();
            }

        }
    }
}
