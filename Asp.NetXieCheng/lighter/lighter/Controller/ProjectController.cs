using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using lighter.Data;
using lighter.Data.Project;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;

namespace lighter.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly LighterDbContext _lighterDbContext;
        public ProjectController(LighterDbContext lighterDbContext)
        {
            _lighterDbContext = lighterDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetListAsync(CancellationToken cancellationToken) 
        {
            return await _lighterDbContext.Projects.ToListAsync(cancellationToken);
        }
        [HttpPost]
        public async Task<ActionResult<Project>> CreateAsync([FromBody] Project project, CancellationToken cancellationToken)
        {
            _lighterDbContext.Projects.Add(project);
            await _lighterDbContext.SaveChangesAsync(cancellationToken);
            return StatusCode((int)HttpStatusCode.Created, project);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Project>> GetAsync(string id, CancellationToken cancellationToken)
        {
            var project = await _lighterDbContext.Projects.Include(p=>p.Groups).FirstOrDefaultAsync();


            await _lighterDbContext.Entry(project).Collection(p => p.Groups).LoadAsync();
            
            return Ok(project);
          }
    }
}
