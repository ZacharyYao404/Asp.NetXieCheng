using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using lighter.Data;
using lighter.Data.Project;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lighter.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectGroupController : ControllerBase
    {
        private readonly LighterDbContext _lighterDbContext;
        public ProjectGroupController(LighterDbContext lighterDbContext)
        {
            _lighterDbContext = lighterDbContext;
        }
        public IActionResult Index()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ProjectGroup group)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }
            _lighterDbContext.ProjectGroups.Add(group);
            await _lighterDbContext.SaveChangesAsync();
            return StatusCode((int)HttpStatusCode.Created,group);
        }
    }
}
