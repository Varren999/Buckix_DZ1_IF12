//===================================================
// Задание: Даны три числа. Найти наименьшее из них.
//===================================================

using System;

namespace Buckix_DZ1_IF12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(100), b = rnd.Next(100), c = rnd.Next(100);
            Console.WriteLine($"Даны три числа.\na = {a}\nb = {b}\nc = {c}");
            Console.Write("Наименьшее число из них ");
            Console.WriteLine(a < b ? a < c ? a : c : b < c ? b : c);
            Console.ReadKey();
        }
    }
}
