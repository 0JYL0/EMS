using EMS.BAL.Interface;
using EMS.DAL.Interface;
using EMS.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BAL.Implementation
{
    public class ProjectBO : IProject
    {
        private readonly IProjectRepository projectRepository;
        public ProjectBO(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public int DeleteteProjectDetails(int id)
        {
            var isDeleted = projectRepository.DeleteteProjectDetails(id);
            return isDeleted;
        }

        public int DeleteteProjectMemberDetails(int id)
        {
            var isDeleted = projectRepository.DeleteteProjectMemberDetails(id);
            return isDeleted;
        }

        public List<ProjectResponseModel> GetAllProjectDetails()
        {
            var employees = projectRepository.GetAllProjectDetails();
            return employees;
        }

        public List<ProjectMembersResponseModel> GetAllProjectMembersDetails()
        {
            var members = projectRepository.GetAllProjectMembersDetails();
            return members;
        }

        public ProjectResponseModel GetProjectDetailsById(int id)
        {
            var projectDetails = projectRepository.GetProjectDetailsById(id);
            return projectDetails;
        }

        public List<EmployeeResponseModel> GetProjectMembersDetailsById(int id)
        {
            var members = projectRepository.GetProjectMembersDetailsById(id);
            return members;
        }

        public int InsertProjectDetails(ProjectRequestModel RequestModel)
        {
            var isInserted = projectRepository.InsertProjectDetails(RequestModel);
            return isInserted;
        }

        public int InsertProjectMembersDetails(ProjectMembersRequestModel RequestModel)
        {
            var isInserted = projectRepository.InsertProjectMembersDetails(RequestModel);
            return isInserted;
        }

        public int UpdateProjectDetails(ProjectRequestModel RequestModel)
        {
            var isUpdated = projectRepository.UpdateProjectDetails(RequestModel);
            return isUpdated;
        }

        public int UpdateProjectMembersDetails(ProjectMembersRequestModel RequestModel)
        {
            var isUpdated = projectRepository.UpdateProjectMembersDetails(RequestModel);
            return isUpdated;
        }
    }
}
