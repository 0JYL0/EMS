using EMS.BAL.Interface;
using EMS.DAL.Interface;
using EMS.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BAL.Implementation
{
    public class EmployeeBO : IEmployee
    {
        private readonly IEmployeesRepository employeeRepository;
        public EmployeeBO(IEmployeesRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public List<EmployeeResponseModel> AllEmployeeMappingDetails(int id)
        {
            var team = employeeRepository.AllEmployeeMappingDetails(id);
            return team;
        }

        public AuthResponseModel AuthenticateUser(AuthRequestModel authRequest)
        {
            var verifyEmployee = employeeRepository.AuthenticateUser(authRequest);
            return verifyEmployee;
        }

        public int DeleteteEmployeeDetails(int id)
        {
            var isDeleted = employeeRepository.DeleteteEmployeeDetails(id);
            return isDeleted;
        }

        public int DeleteteEmployeeMapDetails(int id)
        {
            var isDeleted = employeeRepository.DeleteteEmployeeMapDetails(id);
            return isDeleted;
        }

        public List<EmployeeResponseModel> GetAllEmployeeDetails()
        {
            var employees = employeeRepository.GetAllEmployeeDetails();
            return employees;
        }

        public EmployeeResponseModel GetEmployeeDetailsById(int id)
        {
            var employee = employeeRepository.GetEmployeeDetailsById(id);
            return employee;
        }

        public EmployeeRequestModel GetEmployeeDetailsByIdUpdate(int id)
        {
            var employee = employeeRepository.GetEmployeeDetailsByIdUpdate(id);
            return employee;
        }

        public int InsertEmployeeDetails(EmployeeRequestModel RequestModel)
        {
            var isInserted = employeeRepository.InsertEmployeeDetails(RequestModel);
            return isInserted;
        }

        public int InsertEmployeeMappingDetails(EmployeeMappingRequestModel RequestModel)
        {
            var isInserted = employeeRepository.InsertEmployeeMappingDetails(RequestModel);
            return isInserted;
        }

        public int UpdateEmployeeDetails(EmployeeRequestModel RequestModel)
        {
            var isUpdated = employeeRepository.UpdateEmployeeDetails(RequestModel);
            return isUpdated;
        }
    }
}
