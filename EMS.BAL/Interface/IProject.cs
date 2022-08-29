using EMS.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BAL.Interface
{
    public interface IProject
    {
        int InsertProjectDetails(ProjectRequestModel RequestModel);
        int UpdateProjectDetails(ProjectRequestModel RequestModel);
        int DeleteteProjectDetails(int id);
        int DeleteteProjectMemberDetails(int id);
        ProjectResponseModel GetProjectDetailsById(int id);
        List<ProjectResponseModel> GetAllProjectDetails();
        int InsertProjectMembersDetails(ProjectMembersRequestModel RequestModel);
        int UpdateProjectMembersDetails(ProjectMembersRequestModel RequestModel);
        List<EmployeeResponseModel> GetProjectMembersDetailsById(int id);
        List<ProjectMembersResponseModel> GetAllProjectMembersDetails();
    }
}
