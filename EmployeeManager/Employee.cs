using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class Employee
    {
        public string FullName { get; set; }
        public string EmployeeID { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate = 9.5m;

        // Validates the length of the employees name (min 1 char || max 50 char)
        public string isValidName()
        {
            Console.WriteLine("Please enter your name (Between 1 and 50 Characters): ");
            FullName = Console.ReadLine();

            while (FullName.Length < 1 || FullName.Length > 50)
            {
                Console.WriteLine("Error Length incorrect.");
                FullName = Console.ReadLine();

            }
            return FullName;
        }

        // Multiplies HoursWorked by HourlyRate (Fixed rate of 9.5)
        public Decimal pay()
        {
            Decimal Final = Decimal.Multiply(HoursWorked, HourlyRate);
            return Final;
        }

        // Formatted Wage using ToString to allow 2 decimal places
        public string formattedWage()
        {
            string FormattedWage = pay().ToString("0.00");
            return FormattedWage;
        }

        // Final output to display all information 
        public override string ToString()
        {
            return "Employee Name: " + FullName + "\nEmployee ID: " +
                EmployeeID + "\nHours Worked: " + HoursWorked + 
                "\n\nTotal Pay: £" + formattedWage();
        }
    }
}
