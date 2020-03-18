using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            person1.Name = "Juan";
            person1.LastName = "Perez";
            Console.WriteLine(person1.Cachipun());
            var person2 = new Person();
            person2.Name = "Pedro";
            person2.LastName = "Rodriguez";
            Console.WriteLine(person2.Cachipun());

        }
    }
}
