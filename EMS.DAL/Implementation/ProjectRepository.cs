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
    public class ProjectRepository : IProjectRepository
    {
        private readonly CompanyDBContext dbContext;
        public ProjectRepository(CompanyDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int DeleteteProjectDetails(int id)
        {
            Project project = new Project();
            project.ProjectId = id;
            dbContext.Project.Remove(project);
            var isDeleted = dbContext.SaveChanges();

            return isDeleted;
        }
        public int DeleteteProjectMemberDetails(int id)
        {
            ProjectMembers project = new ProjectMembers();
            project.Id = id;
            dbContext.ProjectMembers.Remove(project);
            var isDeleted = dbContext.SaveChanges();

            return isDeleted;
        }

        public List<ProjectResponseModel> GetAllProjectDetails()
        {
            var project = dbContext.Project.ToList();

            List<ProjectResponseModel> project0 = new List<ProjectResponseModel>();

            foreach (var project1 in project)
            {
                ProjectResponseModel project2 = new ProjectResponseModel()
                {
                    ProjectId = project1.ProjectId,
                    ProjectName = project1.ProjectName,
                    ProjectDescription = project1.ProjectDescription,
                    ProjectTech = (technology)project1.ProjectTech,
                    StartDate = project1.StartDate.ToShortDateString(),
                    EndDate = project1.EndDate.ToShortDateString(),
                };

                project0.Add(project2);
            }

            return project0;
        }

        public List<ProjectMembersResponseModel> GetAllProjectMembersDetails()
        {
            var project = dbContext.ProjectMembers.ToList();

            List<ProjectMembersResponseModel> project0 = new List<ProjectMembersResponseModel>();

            foreach (var project1 in project)
            {
                ProjectMembersResponseModel project2 = new ProjectMembersResponseModel()
                {
                    projectId = project1.ProjectId,
                    employeeId = project1.EmployeeId,
                    JoiningDate = project1.JoiningDate,
                };

                project0.Add(project2);
            }

            return project0;
        }

        public ProjectResponseModel GetProjectDetailsById(int id)
        {
            var projectDetail = dbContext.Project.Where(x => x.ProjectId == id).FirstOrDefault();

            ProjectResponseModel projectResponse = new ProjectResponseModel()
            {
                ProjectId = projectDetail.ProjectId,
                ProjectName = projectDetail.ProjectName,
                ProjectDescription = projectDetail.ProjectDescription,
                ProjectTech = (technology)projectDetail.ProjectTech,
                StartDate = projectDetail.StartDate.ToString("yyyy-MM-dd"),
                EndDate = projectDetail.EndDate.ToString("yyyy-MM-dd"),
            };

            return projectResponse;
        }

        public List<EmployeeResponseModel> GetProjectMembersDetailsById(int id)
        {
            var validateId = dbContext.ProjectMembers.Where(x => x.ProjectId == id).FirstOrDefault();

            List<EmployeeResponseModel> responseModels = new List<EmployeeResponseModel>();

            if (validateId != null)
            {
                var employeeList = dbContext.ProjectMembers.Where(x => x.ProjectId.Equals(id)).Select(y => new {y.EmployeeId, y.Id}).ToList();

                foreach (var item in employeeList)
                {
                    var employee = dbContext.Employee.Where(x => x.EmployeeId == item.EmployeeId).Select(y => y).ToList();
                    EmployeeResponseModel employeeResponse = new EmployeeResponseModel();
                    employeeResponse.Id = item.Id;
                    foreach (var employees in employee)
                    {
                        employeeResponse.EmployeeId = employees.EmployeeId;
                        employeeResponse.EmployeeName = employees.EmployeeName;
                        employeeResponse.EmployeeEmail = employees.EmployeeEmail;
                        employeeResponse.Role = employees.Role;
                        employeeResponse.Technology = employees.Technology;

                        responseModels.Add(employeeResponse);
                    }
                }


            }
            return responseModels;
        }

        public int InsertProjectDetails(ProjectRequestModel RequestModel)
        {
            Project project = new Project()
            {
                ProjectName = RequestModel.projectName,
                ProjectDescription = RequestModel.projectDescription,
                ProjectTech = RequestModel.projectTech,
                StartDate = RequestModel.StartDate,
                EndDate = RequestModel.EndDate,
            };

            dbContext.Project.Add(project);
            var isInserted = dbContext.SaveChanges();

            return isInserted;
        }

        public int InsertProjectMembersDetails(ProjectMembersRequestModel RequestModel)
        {
            ProjectMembers project = new ProjectMembers()
            {
                ProjectId = RequestModel.projectId,
                EmployeeId = RequestModel.employeeId,
                JoiningDate = RequestModel.JoiningDate,
            };

            dbContext.ProjectMembers.Add(project);
            var isInserted = dbContext.SaveChanges();

            return isInserted;
        }

        public int UpdateProjectDetails(ProjectRequestModel RequestModel)
        {
            Project project = new Project()
            {
                ProjectId = RequestModel.projectId,
                ProjectName = RequestModel.projectName,
                ProjectDescription = RequestModel.projectDescription,
                ProjectTech = RequestModel.projectTech,
                StartDate = RequestModel.StartDate,
                EndDate = RequestModel.EndDate,
            };

            dbContext.Project.Attach(project);
            dbContext.Project.Update(project);
            var isUpdated = dbContext.SaveChanges();

            return isUpdated;
        }

        public int UpdateProjectMembersDetails(ProjectMembersRequestModel RequestModel)
        {
            ProjectMembers projectMembers = new ProjectMembers()
            {
                EmployeeId = RequestModel.employeeId,
                JoiningDate = RequestModel.JoiningDate,
            };

            dbContext.ProjectMembers.Attach(projectMembers);
            dbContext.ProjectMembers.Update(projectMembers);
            var isUpdated = dbContext.SaveChanges();

            return isUpdated;
        }
    }
}
