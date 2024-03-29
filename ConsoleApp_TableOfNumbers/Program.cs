using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TableOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to print Table:");
            int n = Convert.ToInt32(Console.ReadLine());
            int j, c;
            for (j = 1; j <= 20; j++)
            {
                c = n * j;
                Console.Write("{0}*{1}={2},\n ", n, j, c);
            }
            
            Console.ReadLine();
        }
    }
}
