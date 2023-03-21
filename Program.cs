using app;
using System;
using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
    {
        //input the number of emplyees
        Console.WriteLine("How many employees did you have ? ");
        var NumberOfEmployees = Convert.ToInt32(Console.ReadLine());

        //define array of employees
        Employee[] employees = new Employee[NumberOfEmployees];
        //take the input
        for (int index = 0; index < NumberOfEmployees; index++)
        {
            //define object of class employee
            Employee employee = new Employee();

            Console.Write("What is your first name ? ");
            employee.FirstName = Console.ReadLine();

            Console.Write("What is your last name ? ");
            employee.LastName = Console.ReadLine();
            
            Console.Write("what is your wage ?");
            employee.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many hours do you work monthly ? ");
            employee.Hours = Convert.ToInt32(Console.ReadLine());

            employees[index] = employee;
            Console.WriteLine("\n---------------------------------------------------------\n\n\n");


        }
        for (int index = 0; index< NumberOfEmployees; index++)
        {
             Employee.printvalues(employees[index]);

        }




    }
}
