// See https://aka.ms/new-console-template for more information
using System;

class program
{
    
    static void Main(string [] args)
    {
        Console.WriteLine("Enter n1");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter n2");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The perfect numbers from" + n1 + "to" + n2 + "are :");

        for (int i=n1; i <= n2; i++)
        {
            int sum = 0;

            for (int j=1 ; j <i ; j++)
            {
                if (i % j == 0)
                {
                    sum += j;
                }
            }
            if (sum == i)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadKey();
    }
}