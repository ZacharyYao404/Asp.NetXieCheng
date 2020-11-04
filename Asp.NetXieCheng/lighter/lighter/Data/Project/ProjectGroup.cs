using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lighter.Data.Project
{
    public class ProjectGroup:Entity
    {

        public string Name { get; set; }
        [Required]
        public string ProjectId { get; set; }
        public Project Project { get; set; }
        public List<Member> Members { get; set; }
    }
}
