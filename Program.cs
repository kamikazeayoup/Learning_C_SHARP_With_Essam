using app;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Money m1 = new Money(1.00m);
        Money m2 = new Money(2.00m);
        Money m3 = m1 + m2;
        Money m4 = m1 - m2; 
        var m5 = m1 > m2;
        var m6 = m1 < m2;

        Console.WriteLine(m3.Amount);
        Console.WriteLine(m4.Amount);
        Console.WriteLine(m5);
        Console.WriteLine(m6);


    }
}

 