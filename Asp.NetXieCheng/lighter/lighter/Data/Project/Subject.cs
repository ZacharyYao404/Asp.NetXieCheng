using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace lighter.Data.Project
{
    public class Subject:Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public List<SubjectProject> SubjectProjects { get; set; }
    }
}