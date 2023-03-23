using app;
using System;
using System.Collections.Generic;
    class Program
    {
    static void Main(string[] args)
    {
        //this program was made to check the date that you enter, using oop principles. 

        //leap year
        Date d1 = new Date(29 , 2 , 2024);
       Console.WriteLine(d1.PrintDate());
    }
}
