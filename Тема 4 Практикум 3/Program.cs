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
            Console.Title=""
            //создаю массив для перебора слов
            string[] words = new string[5];
            //запрашиваю слова у пользователя
           for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Enter a word ");
                words[i] = Console.ReadLine();
              
            }
           //создаю исключение для каждого слова 
            foreach (string word in words)
            {
                Console.Write(word + "  ");
                    

            }
        

        }
    }
}
