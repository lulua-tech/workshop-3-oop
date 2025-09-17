using forgeblade_hr_system;

// Creating a User object:
var user1 = new User("1", "george.smith@hotmail.com", "password123");
Console.WriteLine(user1);

// Updating the user's profile:
user1.UpdatePassword("password12345");
Console.WriteLine(user1);

// Creating an Employee object:
var employee1 = new Employee("E001", "George Smith", new DateTime(1990, 5, 15), "Software Engineer", new Department("IT", "Bob Norman"), 60000);
Console.WriteLine(employee1);

// Employee requests a holiday:
Employee.RequestHoliday(new DateTime(2025, 05, 20), new DateTime(2025, 05, 30));   

// Employee adds sick leave:
Employee.AddSickLeave(new DateTime(2023, 11, 5), "Got the flu");

// Employee views their absences:
employee1.ViewAbsences();

// Creating another Employee object:
var employee2 = new Employee("E002", "Martha Brown", new DateTime(1985, 8, 25), "QA Engineer", new Department("IT", "Bob Norman"), 55000);
Console.WriteLine(employee2);

// Creating a list of employees for the HR Manager:
var employees = new List<Employee> { employee1, employee2 };
foreach (var emp in employees){
    Console.WriteLine(emp);
}

// Creating an HR Manager object:
var hrManager = new HRManager("E003", "Alice Johnson", new DateTime(1980, 3, 10), "HR Manager", new Department("HR", "Susan Lee"), 80000, employees);
Console.WriteLine(hrManager);

// HR Manager views all employees:
var allEmployees = hrManager.ViewEmployees();
foreach (var emp in allEmployees)
{
    Console.WriteLine(emp);
}

// HR Manager adds a new employee:
var employee3 = new Employee("E004", "John Doe", new DateTime(1992, 12, 1), "DevOps Engineer", new Department("IT", "Bob Norman"), 65000);
hrManager.AddEmployee(employee3);

Console.WriteLine("After adding a new employee:");
var allEmployeesUpdated = hrManager.ViewEmployees();
foreach (var emp in allEmployeesUpdated)
{
    Console.WriteLine(emp);
}

// Creating a Floor Manager object:
var floorManager = new FloorManager("E005", "Michael Scott", new DateTime(1975, 7, 20), "Floor Manager", new Department("Operations", "Jim Harwood"), 70000);
Console.WriteLine(floorManager);

// Floor Manager approves a holiday:
FloorManager.ApproveHoliday();

// Floor Manager views employee absences:
FloorManager.ViewEmployeeAbsences();

