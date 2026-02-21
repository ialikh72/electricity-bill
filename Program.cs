using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter units:");
        double units = double.Parse(Console.ReadLine());
        double bill = 0;
        if (units <= 50)
        {
            bill = units * 0.5;
        }
        else if (units <= 100)
        {
            bill = 50 * 0.5 + (units - 50) * 0.75;
        }
        else
        {
            bill = 50 * 0.5 + 50 * 0.75 + (units -100)* 1;
        }
       
        Console.WriteLine("total bill is:"+bill);
    }
}
