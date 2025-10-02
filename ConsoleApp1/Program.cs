using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, I'm Islam's Carpet Cleaning Service");
        Console.WriteLine("$25 per small carpet");
        Console.WriteLine("$35 per large carpet");
        Console.WriteLine("Sales tax rate is 6%");
        Console.WriteLine("Estimates are valid for 30 days");
        Console.WriteLine("==================================");

        Console.WriteLine("Enter the number of small carpets:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of large carpets:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number * 25 + number2 * 35;
        Console.WriteLine("Before tax total = " + sum);

        double tax = sum * 0.06;
        double total = sum + tax;

        Console.WriteLine("Tax (6%) = " + tax);
        Console.WriteLine("After tax total = " + total);
        Console.WriteLine("This estimate is valid for 30 days.");
    }
}