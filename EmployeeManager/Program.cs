

using EmployeeManager;

Employee employee = new Employee();

string HoursWorkedString;
string empIDString;

Console.WriteLine(employee.isValidName());

Console.WriteLine("Enter employee ID (Case sensitce e.g., X56): ");
empIDString = Console.ReadLine();

while(employee.regexID(empIDString) == false)
{
    Console.WriteLine("Please try again.");
    empIDString = Console.ReadLine();
}
Console.WriteLine("ID is now valid.");
employee.EmployeeID = empIDString;

Console.WriteLine("Enter hours worked: ");
HoursWorkedString = Console.ReadLine();
employee.HoursWorked = Convert.ToDecimal(HoursWorkedString);

Console.WriteLine (employee.ToString());