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
            int input, butunson = int.MaxValue, maxCount = 0, count = 0, qiymat = 0;
            do
            {
                Console.Write("butun son kiriting : ");
                input = int.Parse(Console.ReadLine());

                if (butunson == input)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        qiymat = butunson;
                    }
                    count = 1;
                    butunson = input;
                }
            } while (count != 0);
            Console.WriteLine("Bir birini takrorlaydigan sonlar uchun eng uzuni : ");



        }
    }
}
