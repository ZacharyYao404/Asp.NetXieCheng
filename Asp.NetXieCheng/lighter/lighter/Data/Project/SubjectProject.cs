using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lighter.Data.Project
{
    public class SubjectProject:Entity
    {
        public string ProjectId { get; set; }
        public string SubjectId { get; set; }
        public Project Project { get; set; }
        public Subject Subject { get; set; }

    }
}
