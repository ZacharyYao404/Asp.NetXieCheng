using lighter.Shared;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace lighter.Data.Project
{
    public class Task:Entity
    {
        public string Title { get; set; }
        public string SectionId { get; set; }
        public string Description { get; set; }
        public string ProjectId { get; set; }
        public string MemberId { get; set; }
        public Member Member { get; set; }
        public EnumTaskStatus Status { get; set; }

    }
}
