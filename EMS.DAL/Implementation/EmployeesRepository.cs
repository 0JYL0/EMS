using EMP.Common;
using EMS.DAL.Interface;
using EMS.DL;
using EMS.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMS.DAL.Implementation
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly CompanyDBContext companyDBContext;

        public EmployeesRepository(CompanyDBContext companyDBContext)
        {
            this.companyDBContext = companyDBContext;
        }

        public AuthResponseModel AuthenticateUser(AuthRequestModel authRequest)
        {
            var employee = companyDBContext.Employee.Where(x => x.EmployeeEmail == authRequest.Email && x.Password == authRequest.Password).
                Select(y => new { y.EmployeeId, y.Department }).FirstOrDefault();

            if (employee != null)
            {
                AuthResponseModel auth = new AuthResponseModel()
                {
                    EmployeeId = employee.EmployeeId,
                    Department = employee.Department,
                };

                return auth;
            }
            else
            {
                AuthResponseModel auth = new AuthResponseModel()
                {
                    EmployeeId = 0,
                    Department = 0,
                };

                return auth;

            }

        }

        public int DeleteteEmployeeDetails(int id)
        {
            Employee employee = new Employee();
            employee.EmployeeId = id;
            companyDBContext.Employee.Remove(employee);
            var isDeleted = companyDBContext.SaveChanges();
            return isDeleted;
        }

        public int DeleteteEmployeeMapDetails(int id)
        {
            EmployeeMapping employee = new EmployeeMapping();
            employee.Id = id;
            companyDBContext.EmployeeMapping.Remove(employee);
            var isDeleted = companyDBContext.SaveChanges();
            return isDeleted;
        }

        public List<EmployeeResponseModel> GetAllEmployeeDetails()
        {
            var employee = companyDBContext.Employee.ToList();
            List<EmployeeResponseModel> employeeResponseModels = new List<EmployeeResponseModel>();

            foreach (var employees in employee)
            {
                EmployeeResponseModel employeeResponseModels1 = new EmployeeResponseModel()
                {
                    EmployeeId = employees.EmployeeId,
                    EmployeeName = employees.EmployeeName,
                    EmployeeAddress = employees.EmployeeAddress,
                    EmployeeEmail = employees.EmployeeEmail,
                    EmployeeExperience = employees.EmployeeExperience,
                    Password = employees.Password,
                    Technology = employees.Technology,
                    Role = employees.Role,
                    Department = employees.Department,
                    EmployeeJoiningDate = employees.EmployeeJoiningDate.ToString("yyyy/MM/dd"),
                };
                employeeResponseModels.Add(employeeResponseModels1);
            }
            return employeeResponseModels;
        }

        public List<EmployeeResponseModel> AllEmployeeMappingDetails(int id)
        {

            var employee = companyDBContext.Employee.ToList();
            var employeeMap = companyDBContext.EmployeeMapping.ToList();

            List<EmployeeResponseModel> employeeResponse = new List<EmployeeResponseModel>();

            var isManager = employee.Where(x => x.Department == 2 && x.EmployeeId == id).FirstOrDefault();

            if (isManager != null)
            {
                var employeesIds = employeeMap.Where(x => x.ManagerId == id).Select(x => new { x.EmployeeId, x.Id }).ToList();

                foreach (var employeeId in employeesIds)
                {
                    var employee1 = employee.Where(x => x.EmployeeId == employeeId.EmployeeId).ToList();
                    EmployeeResponseModel employeeModel = new EmployeeResponseModel();
                    employeeModel.Id = employeeId.Id;
                    foreach (var employ in employee1)
                    {
                        employeeModel.EmployeeId = employ.EmployeeId;
                        employeeModel.EmployeeName = employ.EmployeeName;
                        employeeModel.EmployeeEmail = employ.EmployeeEmail;
                        employeeModel.Role = employ.Role;
                        employeeModel.Technology = employ.Technology;
                        employeeModel.EmployeeJoiningDate = employ.EmployeeJoiningDate.ToString("yyyy/MM/dd");
                        
                        employeeResponse.Add(employeeModel);
                    }
                }
            }
            return employeeResponse;
        }

        public EmployeeResponseModel GetEmployeeDetailsById(int id)
        {
            var employees = companyDBContext.Employee.Where(x => x.EmployeeId == id).FirstOrDefault();

            EmployeeResponseModel employeeResponse = new EmployeeResponseModel()
            {
                EmployeeId = employees.EmployeeId,
                EmployeeName = employees.EmployeeName,
                EmployeeAddress = employees.EmployeeAddress,
                EmployeeEmail = employees.EmployeeEmail,
                EmployeeExperience = employees.EmployeeExperience,
                EmployeeJoiningDate = employees.EmployeeJoiningDate.ToString("yyyy-MM-dd"),
                Role = employees.Role,
                Department = employees.Department,
                Technology = employees.Technology,
            };

            return employeeResponse;
        }

        public int InsertEmployeeDetails(EmployeeRequestModel RequestModel)
        {
            Employee employee = new Employee()
            {
                EmployeeName = RequestModel.EmployeeName,
                EmployeeAddress = RequestModel.EmployeeAddress,
                EmployeeEmail = RequestModel.EmployeeEmail,
                Password = RequestModel.Password,
                EmployeeExperience = RequestModel.EmployeeExperience,
                EmployeeJoiningDate = RequestModel.EmployeeJoiningDate,
                Technology = RequestModel.Technology,
                Role = RequestModel.Role,
                Department = RequestModel.Department
            };

            companyDBContext.Employee.Add(employee);
            var isInserted = companyDBContext.SaveChanges();

            return isInserted;
        }

        public int InsertEmployeeMappingDetails(EmployeeMappingRequestModel RequestModel)
        {
            EmployeeMapping employeeMapping = new EmployeeMapping()
            {
                ManagerId = RequestModel.ManagerId,
                EmployeeId = RequestModel.EmployeeId,
            };

            companyDBContext.EmployeeMapping.Add(employeeMapping);
            var isInserted = companyDBContext.SaveChanges();

            return isInserted;
        }

        public int UpdateEmployeeDetails(EmployeeRequestModel RequestModel)
        {
            Employee employee = new Employee()
            {
                EmployeeId = RequestModel.EmployeeId,
                EmployeeName = RequestModel.EmployeeName,
                EmployeeAddress = RequestModel.EmployeeAddress,
                EmployeeEmail = RequestModel.EmployeeEmail,
                Password = RequestModel.Password,
                EmployeeJoiningDate = RequestModel.EmployeeJoiningDate,
                EmployeeExperience = RequestModel.EmployeeExperience,
                Technology = (int)RequestModel.Technology,
                Role = (int)RequestModel.Role,
                Department = (int)RequestModel.Department
            };

            companyDBContext.Employee.Attach(employee);
            companyDBContext.Employee.Update(employee);
            var isUpdated = companyDBContext.SaveChanges();

            return isUpdated;
        }

        public EmployeeRequestModel GetEmployeeDetailsByIdUpdate(int id)
        {
            var employees = companyDBContext.Employee.Where(x => x.EmployeeId == id).FirstOrDefault();

            EmployeeRequestModel employeeResponse = new EmployeeRequestModel()
            {
                EmployeeId = employees.EmployeeId,
                EmployeeName = employees.EmployeeName,
                EmployeeAddress = employees.EmployeeAddress,
                EmployeeEmail = employees.EmployeeEmail,
                Password = employees.Password,
                EmployeeExperience = employees.EmployeeExperience,
                EmployeeJoiningDate = employees.EmployeeJoiningDate,
                Technology = employees.Technology,
                Role = employees.Role,
                Department = employees.Department
            };

            return employeeResponse;
        }
    }
}
