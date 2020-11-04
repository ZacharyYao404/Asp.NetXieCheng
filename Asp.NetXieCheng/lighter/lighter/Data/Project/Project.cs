using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lighter.Data.Project
{
    public class Project:Entity
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SupervisorId { get; set; }
        public string PlanId { get; set; }
        public List<ProjectGroup> Groups { get; set; }
        public List<Task> Tasks { get; set; }
        public List<SubjectProject> SubjectProjects { get; set; }

    }
}
