using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {


        /* static void Func()
         {
             int x = 8;
             double Y = (3 * Math.Pow(x, 2) + (8 * x )- 10)/15;
             Console.WriteLine(Y);

         }
         static void Main(string[] args)
         {
             int n=Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= n; i++)
             {
                 Func();
             }
         }*/




        /*  static void Func()
          {

              for(int x=1;x<=6;x+=2)
              {

                  double y = Math.Pow(x, 2);
                  Console.WriteLine(y);
              }


          }
          static void Main(string[] args)
          {
              int n = Convert.ToInt32(Console.ReadLine());
              for (int i = 1; i <= n; i++)
              {
                  Func();
              }
          }
        */

        static void Func()
        {
            Console.WriteLine("enter a = ");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("ENTER B= ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? a : b;




        }
        static void Func2()
        {
            //int i = 10;
            //int a = 20;
            //int b = 30;

            //Console.WriteLine($"{a + b + i / 3}");

            int h = 3;
            for (int x = -9; x <= 9; x += h)
            {
                double y = 4 * x * x + 5 * x - 10;
                Console.WriteLine($"x={x}, y= {y}");
            }
        }
       









}
}
