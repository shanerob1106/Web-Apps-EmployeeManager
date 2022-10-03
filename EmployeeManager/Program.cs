

using EmployeeManager;

Employee employee = new Employee();

// Temporary variables for the ID and hours worked
int HoursWorked;
string empIDString;
string option;

Console.WriteLine("---===  Welcome to Employee Manager 1.0  ===---" + 
    "\nAdd New Employee (A) " +
    "\nList Current Employees (B) " + 
    "\nRemove and Employee (C) " + 
    "\nQuit (Q) ");
option = Console.ReadLine();

if(option == "A" || option == "a")
{
    addEmp();
}
else if(option == "B" || option == "b")
{
    Console.WriteLine("Listing Employees... ");
}
else if (option == "C" || option == "c")
{
    Console.WriteLine("Remove Employee based on position: ");
}else if(option == "Q" || option == "q")
{
    Console.WriteLine("Thank you for using Employee Manager 1.0");
    Environment.Exit(0);
}

void addEmp()
{
    // Checks to see if the employee name is valid
    Console.WriteLine(employee.isValidName());

    // Checks the employeeID against regex to ensure correct pattern (e.g., X56)
    Console.WriteLine("Enter employee ID (Case sensitce e.g., X56): ");
    empIDString = Console.ReadLine();

    // While loop to keep asking till valid data is given 
    while (employee.regexID(empIDString) == false)
    {
        Console.WriteLine("Please try again.");
        empIDString = Console.ReadLine();
    }
    employee.EmployeeID = empIDString;

    // Checks the total hours to ensure the working amounts have been reached (Min: 1 || Max: 100 Hours)
    Console.WriteLine("Enter hours worked: ");
    HoursWorked = Convert.ToInt32(Console.ReadLine());

    // Another while looop to keep checking to ensure the data is valid
    while (employee.TotalHours(HoursWorked) == false)
    {
        Console.WriteLine("Incorrecct value. Please try again. ");
        HoursWorked = Convert.ToInt32(Console.ReadLine());
    }
    employee.HoursWorked = HoursWorked;

    // prints the ToString function in the Employee.cs to the console once all data is correct 
    Console.WriteLine(employee.ToString());

}
