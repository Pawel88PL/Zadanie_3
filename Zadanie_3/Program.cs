using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Program oblicza największy wspólny dzielnik dwóch dodatnich liczb całkowitych.");
            Console.WriteLine("Wykorzystano algorytm Euklidesa nie używając operacji dzielenia.");
            Console.WriteLine("A - B = (n - m) * k");
            Console.WriteLine();

            int numberA, numberB, numberACoppy, numberBCoppy;

            Console.Write("Podaj pierwszą liczbę: ");
            numberA = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            numberB = int.Parse(Console.ReadLine());

            numberACoppy = numberA;
            numberBCoppy = numberB;

            while (numberA != numberB)
            {
                if (numberA > numberB)
                {
                    numberA -= numberB;
                }
                else
                {
                    numberB -= numberA;
                }
            }
            

            Console.WriteLine();
            Console.WriteLine($"Największy wspólny dzielnik liczb ({numberACoppy}, {numberBCoppy}) wynosi: " + numberA);

            Console.ReadLine();
        }
    }
}
