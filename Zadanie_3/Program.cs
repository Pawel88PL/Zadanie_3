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

            // Zadeklarowanie zmiennych.
            int numberA, numberB, numberACoppy, numberBCoppy;
            string czyKontynuacja;

            do
            {
                // Opis programu.
                Console.WriteLine("Program oblicza największy wspólny dzielnik dwóch dodatnich liczb całkowitych.");
                Console.WriteLine("Wykorzystano algorytm Euklidesa nie używając operacji dzielenia.");
                Console.WriteLine();

                // Nadanie zmiennym wartości pobranej od użytkownika
                Console.Write("Podaj pierwszą liczbę: ");
                numberA = int.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                numberB = int.Parse(Console.ReadLine());

                // Stworzenie kopii pobranych zmiennych dla liczb "a" i "b".
                numberACoppy = numberA;
                numberBCoppy = numberB;

                // Wykonanie działania w pętli.
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

                // Wyświetlenie wyniku i zapytanie o kontynuację działania programu.
                Console.WriteLine();
                Console.WriteLine($"Największy wspólny dzielnik liczb ({numberACoppy}, {numberBCoppy}) wynosi: " + numberA);
                Console.WriteLine();
                Console.WriteLine("Czy zakończyć działanie programu? (tak/nie)");
                czyKontynuacja = Console.ReadLine();
                Console.WriteLine();


            }
            while (czyKontynuacja == "nie");
        }
    }
}
