using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Employee
    {
       public static double TAX = 0.03;
        public String FirstName;
        public String LastName;
        public double Wage;
        public int Hours;

        public static void printvalues(Employee employees)
        {
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine($"\nYour first name is : {employees.FirstName}");
            Console.WriteLine($"Your Last name is : {employees.LastName}");
            Console.WriteLine($"Your Wage is : {employees.Wage}");
            Console.WriteLine($"Your Total Hours is : {employees.Hours}");
            double SalaryAfterTax = (employees.Wage * employees.Hours) - (employees.Wage * employees.Hours * Employee.TAX);
            Console.WriteLine($"The salary After tax = {SalaryAfterTax}");        }
    }
}
