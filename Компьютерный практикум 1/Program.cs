using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тема  Компьютерный практикум (Ботнарь)";

            Console.CursorVisible = false;

            Console.WindowWidth = 60;

            Console.WindowHeight = 25;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.Write("Имя=  ");

            string name = Console.ReadLine();


            Console.WriteLine ($"  {name} Привет  ");
            bool capsLock = Console.CapsLock;
            bool numLock = Console.NumberLock;

            Console.WriteLine("CapsLock: " + capsLock);
            Console.WriteLine("NumLock: " + numLock);

            Console.ReadLine();
        }
    }
}
