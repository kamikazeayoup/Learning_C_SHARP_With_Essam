using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Report
    {
        public delegate bool IlligalReport(Employee e);
        public void ProcessEmployee(Employee[] employee , string title , IlligalReport islegible )
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach ( var e in employee )
            {
                if(islegible(e)){
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales}");
                }

            }
            Console.WriteLine("\n\n");
        }

    }
}
