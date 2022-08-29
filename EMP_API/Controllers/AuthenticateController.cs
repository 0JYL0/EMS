using EMS.BAL.Interface;
using EMS.MODEL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMP_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : ControllerBase
    {
        private readonly IEmployee employee;

        public AuthenticateController(IEmployee employee)
        {
            this.employee = employee;
        }

        [HttpPost]
        [Route("AuthenticateUser")]
        public IActionResult Verify(AuthRequestModel authRequest)
        {

            var ValidateUser = employee.AuthenticateUser(authRequest);

            if (ValidateUser.Department != 0 && ValidateUser.EmployeeId != 0)
            {
                return Ok(ValidateUser);
            }
            else
            {
                return BadRequest(new
                {
                    StatusCode = 500,
                    Message = "Invalid username and password"
                });
            }
        }

    }
}
