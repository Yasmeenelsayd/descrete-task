// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n1");
        int n1= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter n2");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The prime numbers between " + n1 + "and" + n2 + "are :");

        for (int i=n1; i <= n2 ; i++)
        {
            int counter = 0;

            for (int j=2; j<= i/2 ; j++)
            {
                if (i%j==0)
                {
                    counter++;
                    break;
                }
            }
            if (counter== 0 && i != 1)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadKey();

    }
}
