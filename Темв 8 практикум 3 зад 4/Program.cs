using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //int c = 30;

            //int min = Math.Min(a, Math.Min(b, c));




            //Console.WriteLine(min);

            //int a = 10;
            //int b = 20;
            //int c = 30;
            //int d = 40;

            //int min = Math.Max(a, Math.Max(b,Math.Max(c,d)));

            //Console.WriteLine(min);

            int a = 10;
            int b = 20;

            int max1 = (a > 2 * b) ? a : 2 * b;
            int max2 = (2 * a - b > b) ? 2 * a - b : b;

          int z= Math.Max(max1, max2);

            Console.WriteLine(z);





        }
    }
}
