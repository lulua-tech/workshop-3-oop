namespace forgeblade_hr_system;

public class FloorManager(string employeeId, string name, DateTime dateOfBirth, string role, Department department, float salary) : Employee(employeeId, name, dateOfBirth, role, department, salary)
{
    public static void ApproveHoliday()
    {
        Console.WriteLine("Approving holiday for employees.");
    }
    
    public static void ViewEmployeeAbsences()
    {
        Console.WriteLine("Viewing employee absences.");
    }
}