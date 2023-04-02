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
            int[] massiv = { 3, 7, 5, 2, 8, 4 };
            int n = massiv.Length;
         
            int k = 2;
            int l = 4;
           
            int temp = massiv[k];
            massiv[k] = massiv[l];
            massiv[l] = temp;
          
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{massiv[i]} ");
            }
        }
    }
}
