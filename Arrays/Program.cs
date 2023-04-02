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
            int[] massiv = { 2, 8, 3, 7, 5, 1, 4 };
            int n = massiv.Length;

            // Dastlabki toq songacha bo'lgan elementlarning yig'indisini hisoblash
            int yigindi = 0;
            int i = 0;
            while (i < n && massiv[i] % 2 != 0)
            {
                yigindi += massiv[i];
                i++;
            }

            // Agar massivda toq sonlar yo'q bo'lsa birinchi va oxirgi elementlar orasidagi elementlarning yig'indisini hisoblash
            if (i == 0 || i == n)
            {
                yigindi = massiv[0] + massiv[n - 1];
            }
            else
            {
                yigindi += massiv[i - 1] + massiv[i];
            }

            // Yig'indini chiqarish
            Console.WriteLine($"Massivning dastlabki toq songacha bo'lgan elementlarining yig'indisi: {yigindi}");
        }
    }
}
