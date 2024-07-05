namespace EmployeeSkillsPortal.Models
{
    public class Staff
    {
         public int Id { get; set; }
        public required string IndexNumber { get; set; }
        public required string FullNames { get; set; }
        public required string Email { get; set; }
        public required string CurrentLocation { get; set; }
        public required string HighestLevelOfEducation { get; set; }
        public required string DutyStation { get; set; }
        public bool AvailabilityForRemoteWork { get; set; }
        
    }
}