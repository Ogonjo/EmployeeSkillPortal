namespace EmployeeSkillsPortal.Models
{
    public class Project
{
    public int Id { get; set; }
    public required string ProjectTitleAndLocation { get; set; }
    public required string LevelOfResponsibility { get; set; }
    public required string BriefDescriptionOfRole { get; set; }
    public int StaffId { get; set; }
    public required Staff Staff { get; set; }
}

}