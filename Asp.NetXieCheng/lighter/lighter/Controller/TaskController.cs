using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lighter.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lighter.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly LighterDbContext _lighterDbContext;
        public TaskController(LighterDbContext lighterDbContext)
        {
            _lighterDbContext = lighterDbContext;
        }
    }
}
