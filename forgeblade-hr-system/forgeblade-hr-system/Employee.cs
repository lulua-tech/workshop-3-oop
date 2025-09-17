namespace forgeblade_hr_system;

public class Employee(string employeeId, string name, DateTime dateOfBirth, string role, Department department, float salary) : User
{
    private string EmployeeId { get; } = employeeId;
    private string Name { get; } = name;
    private DateTime DateOfBirth { get; } = dateOfBirth;
    private string Role { get; } = role;
    private Department Department { get; } = department;
    private float Salary { get; } = salary;

    public override string ToString()
    {
        return $"{EmployeeId}, {Name}, {DateOfBirth.ToShortDateString()}, {Role}, {Department.DepartmentName}, {Salary}";
    }

    public static void RequestHoliday(DateTime startDate, DateTime endDate)
    {
        Console.WriteLine("Holiday requested from " + startDate.ToShortDateString() + " to " +
                          endDate.ToShortDateString());
    }

    public static void AddSickLeave(DateTime date, string reason)
    {
        Console.WriteLine("Sick leave added for " + date.ToShortDateString() + " due to " + reason);
    }

    public void ViewAbsences()
    {
        Console.WriteLine("Viewing absences for " + Name);
    }
}