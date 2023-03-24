using app;
using System;
using System.Collections.Generic;
    class Program
    {
    static void Main(string[] args)
    {
        Dollar dlr = new Dollar
        {
            Price = -1
        };
        Console.WriteLine($"Your Value = {dlr.Price} your total = {dlr.Price * 100}");
    }
}
