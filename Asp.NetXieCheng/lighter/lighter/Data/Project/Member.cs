using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lighter.Data.Project
{
    public class Member
    {
        public string MemberId { get; set; }
        public string ProjectGroupId { get; set; }
        public bool IsAssistant { get; set; }
        public string GroupId { get; set; }
        public ProjectGroup Group { get; set; }
    }
}
