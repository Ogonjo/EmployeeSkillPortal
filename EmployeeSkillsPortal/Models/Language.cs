namespace EmployeeSkillsPortal.Models
{
    public class Language
{
    public int Id { get; set; }
    public required string LanguageName { get; set; }
    public required string LevelOfProficiency { get; set; }
    public int StaffId { get; set; }
    public required Staff Staff { get; set; }
}

}