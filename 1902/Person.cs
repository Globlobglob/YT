using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902
{
    abstract class Person
    {
        string name;
        public string Name { get => name; set => name = value; }

        public Person(string name) { this.name = name; }
        public abstract void Greet();
    }
}
