using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902
{
    class russian:Person
    {
        public russian(string name) : base(name){ }

        public override void Greet()
        {
            Console.WriteLine($"Привет, меня зовут {Name}!");
        }
    }
}
