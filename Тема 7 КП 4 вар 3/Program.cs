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


            Console.Write("enter a sentences");
            string s = Console.ReadLine();
            Console.WriteLine("enter a symbol to  del");
            char x =Convert.ToChar(Console.ReadLine());

            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < sb.Length;)
            {
                if (sb[i] == x)
                {
                    sb.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            string result = sb.ToString();

            Console.WriteLine(result);

        }
    }
}
