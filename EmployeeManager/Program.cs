

using EmployeeManager;

Employee employee = new Employee();

string val;

Console.WriteLine(employee.isValidName());

Console.WriteLine("Enter employee ID: ");
employee.EmployeeID = Console.ReadLine();

Console.WriteLine("Enter hours worked: ");
val = Console.ReadLine();
employee.HoursWorked = Convert.ToDecimal(val);

Console.WriteLine (employee.ToString());