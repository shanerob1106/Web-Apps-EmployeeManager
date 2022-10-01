using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class Employee
    {
        // Getter and setters
        public string FullName { get; set; }
        public string EmployeeID { get; set; }
        public decimal HoursWorked { get; set; }

        // Fixed hourly rate of 9.5 / £9.50
        public decimal HourlyRate = 9.5m;

        // Validates the length of the employees name (min 1 char || max 50 char)
        public string isValidName()
        {
            Console.WriteLine("Please enter your name (Between 1 and 50 Characters): ");
            FullName = Console.ReadLine();

            while (FullName.Length < 1 || FullName.Length > 50)
            {
                Console.WriteLine("Error Length incorrect. Please enter a valid name. ");
                FullName = Console.ReadLine();

            }
            return FullName;
        }

        // Uses regex to ensure there is a capital letter followed by 2 numbers (e.g., X20)
        public Boolean regexID(string empID)
        {
            string patternText = @"^[A-Z]{1}\d{2}$";
            Regex reg = new Regex(patternText);

            if (reg.IsMatch(empID))
            {
                return true;
            }

            return false;
        }

        // Checks to see if the employee has worked more than 100 hours or less than 1
        public Boolean TotalHours(int HoursTotal)
        {
            if(HoursTotal < 1 || HoursTotal > 100)
            {
                return false;
            }

            return true;
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
