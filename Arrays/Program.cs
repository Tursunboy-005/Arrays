using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.Write("Massiv Uzunligini kiriting : ");
            int n = int.Parse(Console.ReadLine());

            int[] massiv = new int[n];

            Console.WriteLine($"Iltimos, {n} ta butun son kiriting ");
           
            for (int i = 0; i < n; i++)
            {
                massiv[i] = int.Parse( Console.ReadLine()); 
            }

            int yigindi = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                yigindi += massiv[i];
            }

            int kopaytma = 1;
            for (int i = 0; i < massiv.Length; i++)
            {
                kopaytma *= massiv[i];
            }

            Console.WriteLine($"Massiv yig'indisi: {yigindi}");
            Console.WriteLine($"Massiv ko'paytmasi: {kopaytma}");

        }
    }
}
