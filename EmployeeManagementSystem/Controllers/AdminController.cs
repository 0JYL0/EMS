using EMP.Common;
using EMS.BAL.Interface;
using EMS.MODEL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly IEmployee employee;
        private readonly IProject project;

        public AdminController(IEmployee employee, IProject project)
        {
            this.employee = employee;
            this.project = project;
        }

        public bool auth()
        {
            var employeeId = HttpContext.Session.GetString("EmployeeId");
            var department = HttpContext.Session.GetString("Department");
            var identify = employeeId == null || department != "1" ? true : false;

            return identify;
        }

        public IActionResult Index()
        {

            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult ListofEmployee()
        {
            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
                var employees = employee.GetAllEmployeeDetails();
                return View(employees);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeRequestModel employeeRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var isInserted = employee.InsertEmployeeDetails(employeeRequest);
                    //TempData["Msg"] = "Inserted";
                    return RedirectToAction(nameof(ListofEmployee));
                }
            }
            catch (Exception e)
            {
                TempData["Msg"] = e.Message;
            }

            return View(employee);

        }

        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
                var employees = employee.GetEmployeeDetailsByIdUpdate(id);
                return View(employees);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditEmployee(EmployeeRequestModel requestModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var isUpdated = employee.UpdateEmployeeDetails(requestModel);
                    //TempData["Msg"] = "Updated";
                    return RedirectToAction(nameof(ListofEmployee));
                }
            }
            catch (Exception e)
            {
                TempData["Msg"] = e.Message;
            }

            return View(employee);
        }

        [HttpGet]
        public IActionResult ListofProject()
        {
            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
                var projects = project.GetAllProjectDetails();
                return View(projects);
            }   
        }

        [HttpGet]
        public IActionResult newProject()
        {
            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult newProject(ProjectRequestModel requestModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var isInserted = project.InsertProjectDetails(requestModel);
                    TempData["Msg"] = "Inserted";
                    return RedirectToAction(nameof(ListofProject));
                }
            }
            catch (Exception e)
            {
                TempData["Msg"] = e.Message;
            }

            return View(project);
        }

        public IActionResult listManager()
        {
            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
            var employees = employee.GetAllEmployeeDetails().Where(x => x.Department == 2).ToList();

            return View(employees);               
            }
        }

        [HttpGet]
        public IActionResult teamMembers(int id)
        {
            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
            ViewBag.ManagerId = id;
            var employees = employee.GetAllEmployeeDetails().Where(x => x.Department == 3).Select(x => new SelectListItem()
            { Text = x.EmployeeName.ToString(), Value = x.EmployeeId.ToString() }).ToList();

            ViewBag.EmployeeId = employees;

            return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult teamMembers(EmployeeMappingRequestModel requestModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var isInserted = employee.InsertEmployeeMappingDetails(requestModel);
                    ViewBag.Msg = "Employee added successfully !";
                    return RedirectToAction("teamEmployee/"+requestModel.ManagerId+"","Admin");
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = "Employee Id already exist !";
            }

            return View();
        }
        
        [HttpGet]
        public IActionResult deleteEmployee(int id)
        {
            try
            {
                var deleted = employee.DeleteteEmployeeDetails(id);
                ViewBag.Msg = "Deleted";
                return View("ListofEmployee");
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
                return View("ListofEmployee");
            }
        }

        [HttpGet]
        public IActionResult teamEmployee(int id)
        {
            try
            {
                var team = employee.AllEmployeeMappingDetails(id);
                return View(team);
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
                return View();
            }
        }

        [HttpGet]
        public IActionResult listOfProjectMembers(int id)
        {
            var employee = project.GetProjectMembersDetailsById(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult addProjectMembers(int id)
        {
            if (auth())
            {
                return RedirectToAction(nameof(Index), "Authenticate");
            }
            else
            {
                ViewBag.ManagerId = id;
                var employees = employee.GetAllEmployeeDetails().Select(x => new SelectListItem()
                { Text = x.EmployeeName.ToString(), Value = x.EmployeeId.ToString() }).ToList();

                ViewBag.EmployeeId = employees;

                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult addProjectMembers(ProjectMembersRequestModel requestModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var isInserted = project.InsertProjectMembersDetails(requestModel);
                    ViewBag.Msg = "Employee added successfully !";
                    return RedirectToAction(nameof(listOfProjectMembers));
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = "Employee Id already exist !";
            }

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("EmployeeId", "");
            HttpContext.Session.SetString("Department", "");
            return RedirectToAction("Index", "Authenticate");
        }
    }
}
