namespace EmployeeSkillsPortal.Models
{
    public class SoftwareExpertise
{
    public int Id { get; set; }
    public required string Expertise { get; set; }
    public required string ExpertiseLevel { get; set; }
    public int StaffId { get; set; }
    public required Staff Staff { get; set; }
}

}