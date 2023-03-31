using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number N=> ");
            int number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            random.Next(number);
            Console.Write("Enter a diviser => ");
            int diviser = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if(i % diviser == 0)
                {
                    Console.WriteLine($"{i}, ");
                }
            }
        }
    }
}
