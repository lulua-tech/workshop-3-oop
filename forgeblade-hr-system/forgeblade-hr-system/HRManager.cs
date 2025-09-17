namespace forgeblade_hr_system;

public class HRManager : Employee
{
    private readonly List<Employee> _employees;
    
    public HRManager(string employeeId, string name, DateTime dateOfBirth, string role, Department department, float salary, List<Employee> employees) : base(employeeId, name, dateOfBirth, role, department, salary)
    {
        _employees = employees;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()}, Manages {_employees.Count} employees";
    }
    
    public List<Employee> ViewEmployees()
    {
        return _employees;
    }
    
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }
}