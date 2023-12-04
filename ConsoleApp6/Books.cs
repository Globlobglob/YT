using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;


namespace ConsoleApp6
{

    class Program
    {

        static Student GetStudent()
        {

            Student student = new Student();    
            student.id=Guid.NewGuid();
            student.name = "Igorevich";
            student.age = 10;

            return student;
        }
       static void Print(Student student)
        {
            Console.WriteLine(student.id);
            Console.WriteLine(student.name);
                Console.WriteLine(student.age);
            Console.WriteLine(student.surname);


        }
        static void Main(string[] args)
        {
            
            var student =GetStudent();
            Print(student);




            ReadKey();



        }
       
    }
    
}
