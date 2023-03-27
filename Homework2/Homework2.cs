using System;
using System.Drawing;
using Homework;

public class Homework2
{
    private static void Problem1()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 7 == 0 && n % 11 == 0)
        {
            Console.WriteLine("It is divisible");
        }

        else
        {
            Console.WriteLine("It is not divisible!!!");
        }
    }

    private static void Problem2()
    {
        int year = Convert.ToInt32(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("It is leap");
        }

        else
        {
            Console.WriteLine("It is not leap");
        }
    }

    private static void Problem3()
    {
        IList<int> primes = new List<int>();

        for (int i = 2; i <= 300; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= 300; j++)
            {
                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primes.Add(i);
            }
        }
        Console.Write(primes[46]);
    }

    private static void Problem4()
    {
        int n1 = 1, n2 = 2, n3;
        int even = 0;

        Console.Write(n1 + " " + n2 + " ");

        for (int j = 2; j < 15; j++)   
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;

            if (n3 % 2 == 0)
            {
                even += n3;
            }
        }
        Console.WriteLine("Sum of the even numbers is: " + even);
    }

    private static void Problem5()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of the digits of the integer is: " + sum);
    }

    private static void Main(string[] args)
    {
        //Console.WriteLine("Problem 1:");
        //Problem1();

        //Console.WriteLine("Problem 2:");
        //Problem2();

        //Console.WriteLine("Problem 3:");
        //Problem3();

        //Console.WriteLine("Problem 4:");
        //Problem4();

        //Console.WriteLine("Problem 5:");
        //Problem5();

        Homework3cs s1 = new Homework3cs();
        Console.WriteLine(s1.id);
        Console.WriteLine(s1.name);
    }
}

