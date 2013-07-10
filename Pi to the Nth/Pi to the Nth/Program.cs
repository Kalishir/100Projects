using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pi_to_the_Nth
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number between 1 and 200 to generate PI; or enter E to Exit");
                string input = Console.ReadLine();

                if (input == "E" || input == "e")
                    break;
                else
                {
                    int n = -1;
                    try
                    {
                        n = Convert.ToInt32(input);
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a valid number");
                        continue;
                    }
                    if (n > 200 || n < 0)
                    {
                        Console.WriteLine("Please Enter a valid number");
                        continue;
                    }
                    Console.WriteLine("PI to " + n + " places is: ");
                    Console.WriteLine(GeneratePI(n));
                }
            }
        }
        static double GeneratePI(int n)
        {
            double a = 1;
            double b = 1 / Math.Sqrt(2);
            double t = 1 / 4f;
            double p = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(t);
            Console.WriteLine(p);
            int ans = 0;
            int x = n;
            while (n > 1)
            {
                n /= 2;
                ans++;
            }
            for (int i = 0; i <= ans; i++)
            {

                double a2 = (a + b) / 2f;
                double b2 = Math.Sqrt(a * b);
                double t2 = t - (p * ((a - a2) * (a - a2)));
                double p2 = 2 * p;
                a = a2;
                b = b2;
                t = t2;
                p = p2;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(t);
                Console.WriteLine(p);
            }
            double PI = ((a + b)*(a + b)) / (4 * t);
            string pie = "3.";
            int poweroften = 10;
            for (int i = 0; i < x; i++)
            {
                int y = (int)(PI * (poweroften));
                poweroften *= 10;
                pie += y % 10;
            }
            Console.WriteLine(pie);
            return PI;
        }
    }
}
