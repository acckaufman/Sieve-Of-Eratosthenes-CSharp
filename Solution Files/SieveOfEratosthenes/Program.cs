//Prime number: number greater than 1, and only divisible by 1 and itself
//1 is not a prime number (not greater than 1)
//2 is a prime number (only even prime number)

using System;

namespace SieveOfEratosthenes
{
     class Program
     {
          static void Main(string[] args)
          {
               //Variables
               string input;
               int number;

               //Get max number from user
               Console.Write("Enter a number: ");
               input = Console.ReadLine();
               int.TryParse(input, out number);

               //Build array of bool values up to number specified by user
               bool[] primeNumbers = new bool[number + 1];
               for (int i = 2; i <= number; i++)
                    primeNumbers[i] = true;

               //Mark multiples as false
               for (int i = 2; i <= number; i++)
               {
                    if (primeNumbers[i])
                    {
                         for (int j = i * 2; j <= number; j += i)
                         {
                              primeNumbers[j] = false;
                         }
                    }
               }

               //Output prime numbers
               Console.WriteLine();
               Console.WriteLine("Prime numbers between 1 and " + number + ":");
               for (int i = 0; i <= number; i++)
               {
                    if (primeNumbers[i] == true)
                         Console.Write(i + " ");
               }
               Console.WriteLine();
               Console.WriteLine();
               Console.Write("Press any key to continue...");
               Console.Read();
          }
     }
}
