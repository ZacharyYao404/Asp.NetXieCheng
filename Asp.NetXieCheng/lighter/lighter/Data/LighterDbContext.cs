using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lighter.Data
{
    public class LighterDbContext:DbContext
    {
        private readonly HttpContext _httpContext;
        public LighterDbContext(DbContextOptions<LighterDbContext> options, IHttpContextAccessor context) : base(options)
        {
            _httpContext = context.HttpContext;
        }
        public DbSet<Project.Project> Projects { get; set; }
        public DbSet<Project.Member> Members { get; set; }
        public DbSet<Project.ProjectGroup> ProjectGroups { get; set; }
        public DbSet<Project.Task> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project.Project>()
                .Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Project.ProjectGroup>()
                .HasOne<Project.Project>(g => g.Project);

            modelBuilder.Entity<Project.SubjectProject>()
                .HasOne<Project.Project>(s => s.Project)
                .WithMany(p => p.SubjectProjects)
                .HasForeignKey(s=>s.ProjectId);

            modelBuilder.Entity<Project.SubjectProject>()
                .HasOne<Project.Subject>(s => s.Subject)
                .WithMany(p=>p.SubjectProjects)
                .HasForeignKey(s => s.SubjectId);
            _httpContext.Request.Headers.TryGetValue("tenantId",out StringValues tenantId);
            modelBuilder.Entity<Entity>().HasQueryFilter(x => x.TenantId == tenantId.FirstOrDefault());
            base.OnModelCreating(modelBuilder);

        }
    }
}
