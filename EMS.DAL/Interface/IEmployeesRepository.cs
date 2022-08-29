using EMS.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DAL.Interface
{
    public interface IEmployeesRepository
    {
        int InsertEmployeeDetails(EmployeeRequestModel RequestModel);
        int UpdateEmployeeDetails(EmployeeRequestModel RequestModel);
        int DeleteteEmployeeDetails(int id);
        int DeleteteEmployeeMapDetails(int id);
        AuthResponseModel AuthenticateUser(AuthRequestModel authRequest);
        EmployeeResponseModel GetEmployeeDetailsById(int id);
        EmployeeRequestModel GetEmployeeDetailsByIdUpdate(int id);
        List<EmployeeResponseModel> GetAllEmployeeDetails();
        int InsertEmployeeMappingDetails(EmployeeMappingRequestModel RequestModel);
        List<EmployeeResponseModel> AllEmployeeMappingDetails(int id);

    }
}
