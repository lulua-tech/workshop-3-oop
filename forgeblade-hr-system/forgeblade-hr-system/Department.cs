namespace forgeblade_hr_system;

public class Department(string departmentName, string managerName)
{
    public string DepartmentName { get; set; } = departmentName;
    
    public string ManagerName { get; set; } = managerName;
}