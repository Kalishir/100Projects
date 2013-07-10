using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the string to be reversed or enter E to exit:");
                string input = Console.ReadLine();
                if (input == "E" || input == "e")
                    break;
                else
                {
                    string output = "";
                    for (int i = input.Length-1; i >=0; i--)
                    {
                        output += input[i];
                    }
                    Console.WriteLine("The reverse of " + input + " is " + output);
                }
            }
        }
    }
}
