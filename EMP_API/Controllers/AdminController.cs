using EMP.Common;
using EMS.BAL.Interface;
using EMS.MODEL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EMP_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IEmployee employee;
        private readonly IProject project;

        public AdminController(IEmployee employee, IProject project)
        {
            this.employee = employee;
            this.project = project;
        }

        [HttpGet]
        [Route("GetAllEmployeeDetails")]
        public IActionResult Get()
        {
            var employees = employee.GetAllEmployeeDetails();
            return Ok(employees);
        }

        [HttpGet]
        [Route("GetEmployeeById")]
        public IActionResult ById(int id)
        {
            var employees = employee.GetEmployeeDetailsById(id);
            return Ok(employees);
        }

        [HttpGet]
        [Route("GetAllManager")]
        public IActionResult listManager()
        {
            var employees = employee.GetAllEmployeeDetails().Where(x => x.Department == 2 ).ToList();

            return Ok(employees);
        }


        [HttpGet]
        [Route("TeamMembers")]
        public IActionResult team(int id)
        {
            var team = employee.AllEmployeeMappingDetails(id);
            return Ok(team);
        }

        [HttpGet]
        [Route("OnlyEmployee")]
        public IActionResult OnlyEmployee()
        {
            var employees = employee.GetAllEmployeeDetails().Where(x => x.Department == 3 ).ToList();
            return Ok(employees);
        }

        [HttpPost]
        [Route("AddMember")]
        public IActionResult AddMember(EmployeeMappingRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var inserted = employee.InsertEmployeeMappingDetails(requestModel);
                return Ok(inserted);
            }
            else
            {
                return BadRequest(new
                {
                    StatusCode = 500,
                    Message = "Invalid data!"
                });
            }
        }


        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Add(EmployeeRequestModel requestModel) 
        {
            if (ModelState.IsValid)
            {
                var isInserted = employee.InsertEmployeeDetails(requestModel);
                return Ok(isInserted);
            }
            else
            {
                return BadRequest(new
                {
                    StatusCode=500,
                    Message = "Try again !"
                });
            }
        }

        [HttpDelete]
        [Route("DeleteEmployee")]
        public IActionResult Delete(int id)
        {
            var isDeleted = employee.DeleteteEmployeeDetails(id);
            return Ok(isDeleted);
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult Update(EmployeeRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var updated = employee.UpdateEmployeeDetails(requestModel);
                return Ok(updated);
            }
            else
            {
                return BadRequest(new
                {
                    StatusCode = 500,
                    Massege = "Invalid Entry"
                });
            }
        }

        [HttpGet]
        [Route("GetAllProject")]
        public IActionResult GetProject()
        {
            var projects = project.GetAllProjectDetails();
            return Ok(projects);
        }

        [HttpGet]
        [Route("GetProjectById")]
        public IActionResult ProjectById(int id)
        {
            var projectDetail = project.GetProjectDetailsById(id);
            return Ok(projectDetail);
        }

        [HttpPost]
        [Route("AddProject")]
        public IActionResult AddProjectDetails(ProjectRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var inserted = project.InsertProjectDetails(requestModel);
                return Ok(inserted);
            }
            else
            {
                return BadRequest(new
                {
                    statusCode = 500,
                    Massege = "Invalid Data !"
                });
            }
        }

        [HttpPut]
        [Route("UpdateProject")]
        public IActionResult UpdateProject(ProjectRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var updated = project.UpdateProjectDetails(requestModel);
                return Ok(updated);
            }
            else
            {
                return BadRequest(new
                {
                    StatusCode = 500,
                    Message = "Invalid Data"
                });
            }
        }

        [HttpDelete]
        [Route("DeleteProject")]
        public IActionResult DeleteProject(int id)
        {
            var isDeleted = project.DeleteteProjectDetails(id);
            return Ok(isDeleted);
        }

        [HttpGet]
        [Route("ProjectMembers")]
        public IActionResult Members(int id)
        {
            var projectMembers = project.GetProjectMembersDetailsById(id);
            return Ok(projectMembers);
        }

        [HttpPost]
        [Route("AddProjectMembers")]
        public IActionResult AddMembers(ProjectMembersRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var inserted = project.InsertProjectMembersDetails(requestModel);
                return Ok(inserted);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        [Route("RemoveMember")]
        public IActionResult DeleteMember(int id)
        {
            var deleted = employee.DeleteteEmployeeMapDetails(id);
            return Ok();
        }

        [HttpDelete]
        [Route("RemoveProjectMember")]
        public IActionResult DeleteProjectMember(int id)
        {
            var deleted = project.DeleteteProjectMemberDetails(id);
            return Ok();
        }
    }
}
