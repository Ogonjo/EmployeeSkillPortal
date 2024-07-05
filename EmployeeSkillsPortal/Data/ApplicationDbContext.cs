using EmployeeSkillsPortal.Models;

namespace EmployeeSkillsPortal.Data
{
    public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Staff> Staffs { get; set; }
    public DbSet<EducationLevel> EducationLevels { get; set; }
    public DbSet<DutyStation> DutyStations { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<SoftwareExpertise> SoftwareExpertises { get; set; }
    public DbSet<Language> Languages { get; set; }
}

    public class DbContext
    {
    }
}