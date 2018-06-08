using System;

namespace PrimeNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int HowMany = 0;
            Console.WriteLine("How many prime numbers do you need? ");
            HowMany = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ok, there are  " + HowMany + " prime numbers:");

            PrintPrimeNumbers(HowMany);

            Console.ReadLine();
        }

        private static void PrintPrimeNumbers(int HowMany)
        {
            if (HowMany > 1)
            {
                int Finded = 0;
                int NumberForTest = 3;

                PrimeNumbers PrimeTest = new PrimeNumbers();

                while (Finded < HowMany)
                {
                    if (PrimeTest.IsThisPrime(NumberForTest))

                    {
                        Console.Write(NumberForTest + " "); Finded++;
                        if (Finded % 10 == 0) Console.WriteLine();
                    }

                    NumberForTest++;
                }
            }
            else Console.WriteLine("Goodbye");
        }
    }
}