using Microsoft.EntityFrameworkCore;

namespace project.model
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Project> Projects { get; set; }
        public DbSet<Subproject> Subprojects { get; set; }
        public DbSet<ResearchFundingProject> ResearchFundingProjects { get; set; }
        public DbSet<ResearchFundingProject> RequestFundingProjects { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Debitor> Debitors { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<Funding> Fundings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Subproject>()
                .HasOne<Project>(s=>s.Project)
                .WithMany();

            builder.Entity<Facility>()
                .HasDiscriminator<string>("FACILITY_TYPE")
                .HasValue<Faculty>("FACULTY")
                .HasValue<Institute>("INSTITUTE");
            
            builder.Entity<Funding>()
                .HasKey(f => new {f.ProjectId, f.DebitorId});

            builder.Entity<Funding>()
                .HasOne<Project>(f => f.Project)
                .WithMany()
                .HasForeignKey(f => f.ProjectId);
            
            builder.Entity<Funding>()
                .HasOne<Debitor>(f => f.Debitor)
                .WithMany()
                .HasForeignKey(f => f.DebitorId);

            builder.Entity<Subproject>()
                .HasOne<Institute>(s=>s.Institute)
                .WithMany();
        }
    }
}