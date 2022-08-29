using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EMS.DL
{
    public partial class Project
    {
        public Project()
        {
            ProjectMembers = new HashSet<ProjectMembers>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public int ProjectTech { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<ProjectMembers> ProjectMembers { get; set; }
    }
}
