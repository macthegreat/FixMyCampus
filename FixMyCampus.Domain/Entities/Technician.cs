namespace FixMyCampus.Domain.Entities;
public class Technician
{
    public int Id {get; set;}
    public string FullName {get; set;} = string.Empty;
    public bool IsActive {get; set;}
}