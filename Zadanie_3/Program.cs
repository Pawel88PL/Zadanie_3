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
            Console.WriteLine();

            int firstNumber, secondNumber, commonDivisor;

            commonDivisor = 0;

            Console.Write("Podaj pierwszą liczbę: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            secondNumber = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine($"Największy wspólny dzielnik liczb ({firstNumber}, {secondNumber}) wynosi: " + commonDivisor);

            Console.ReadLine();
        }
    }
}
