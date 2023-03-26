using app;
using System;
using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
    {
        //this for applying the delegate topic and show the imprtance of it and show the history of lambda expression.
        var emps = new Employee[]
        {
            new Employee {Id = 1 , Name = "Ahmed" , Gender = "Male" , TotalSales = 30000m} ,
            new Employee {Id = 2 , Name = "Mohamed" , Gender = "Male" , TotalSales = 40000m} ,
            new Employee {Id = 3 , Name = "Ali" , Gender = "Male" , TotalSales = 20000m} ,
            new Employee {Id = 4 , Name = "Mamdouh" , Gender = "Male" , TotalSales = 70000m} ,
            new Employee {Id = 5 , Name = "Samir" , Gender = "Male" , TotalSales = 60000m} ,
            new Employee {Id = 6 , Name = "Somia" , Gender = "Famle" , TotalSales = 10000m} ,
            new Employee {Id = 7 , Name = "Hams" , Gender = "Famle" , TotalSales = 90000m} ,
            new Employee {Id = 8 , Name = "Mona" , Gender = "Famle" , TotalSales = 40000m} ,
            new Employee {Id = 9 , Name = "Nadia" , Gender = "Famle" , TotalSales = 20000m} ,
            new Employee {Id = 10 , Name = "injy" , Gender = "Famle" , TotalSales = 50000m} ,
        };
        var rep = new Report();
        rep.ProcessEmployee(emps, "bigger than 60000 ", (e) => e.TotalSales > 60000m);
        rep.ProcessEmployee(emps, "bigger than or equal 30000 and less than 60000", (e) => e.TotalSales >= 30000m && e.TotalSales < 60000m);
        rep.ProcessEmployee(emps, "less than 30000 ", (e) => e.TotalSales < 30000m);
        Console.ReadKey();

    }

   private static void Stock_OnPriceChanged(Stock stock, decimal oldprice)
    {
        string status = "";
        if (oldprice > stock.Price)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            status = "Down";
        }
        else if (oldprice < stock.Price)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            status = "Up";
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            status = "Same";
        }
        Console.WriteLine($"The Old Price {oldprice} is {status} on {stock.Price} ");
    }
}
public delegate void StockPriceChangeHandler(Stock stock , decimal oldprice);
