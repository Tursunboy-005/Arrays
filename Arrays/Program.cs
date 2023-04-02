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

            Console.Write("Iltimos, massiv uzunligini kiriting:");
            int n = int.Parse(Console.ReadLine());

            int[] massiv = new int[n];

            Console.WriteLine($"Iltimos, {n} ta butun sonni kiriting:");
            for (int i = 0; i < n; i++)
            {
                massiv[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Kiritilgan massiv:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(massiv[i] + " ");
            }
            
            int searchNumber = int.Parse(Console.ReadLine());
            
            bool borlik = false;
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] == searchNumber)
                {
                    borlik = true;
                    break;
                }
            }
            if(borlik)
            {
                Console.WriteLine($"{searchNumber} Massivda mavjud");
            }
            else
            {
                Console.WriteLine($"{searchNumber} Massivda mavjud emas ");
            }
        }
    }
}
