using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Task 1
           /* Console.Write("введите координату треугольника x1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите координату треугольника y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());

            //точка а 
                Console.Write("введите координату треугольника x2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите координату треугольника y1=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            //точка б
            Console.Write("введите координату треугольника x3= ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите координату треугольника y1=");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double sideAB = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
            double sideBC = Math.Sqrt((Math.Pow(x2 - x3, 2)) + (Math.Pow(y2 - y3, 2)));
            double sideCA = Math.Sqrt((Math.Pow(x1 - x3, 2)) + (Math.Pow(y1 - y3, 2)));
            double P = sideAB + sideBC + sideCA; 
            double S = (sideAB * sideCA / 2) + (sideBC * sideCA / 2);
            Console.Write($"{P}- периметр \t {S}-площадь  ");*/

            //task 2
            
            /* Console.Write("расстояние =");
            double s = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("расход бензина 100 км == "); 
            double b = Convert.ToDouble(Console.ReadLine()); 
             Console.Write("цена за 1 л == "); 
            double c = Convert.ToDouble(Console.ReadLine()); 
            double cost = b/100 / c * s;
            Console.Write($"{cost}-cost");*/

          
            Console.WriteLine("Цена печенья за 1 кг = 10р");
            Console.WriteLine("Цена яблок за 1 кг = 5р");
            Console.WriteLine("Цена конфет за 1 кг = 50р");
            Console.WriteLine("Сколько кг печенья ?");
            double cookies = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько кг яблок ? ");
            double apple = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько кг конфет ?");
            double candys = Convert.ToDouble(Console.ReadLine());
            int costCookies = 10; int costApple = 5; int costCandys = 50; double costAll = (costApple * apple) + (costCandys * candys) + (costCookies * cookies);
            Console.WriteLine($"Цена за все = {costAll}");
        }
    }
}
