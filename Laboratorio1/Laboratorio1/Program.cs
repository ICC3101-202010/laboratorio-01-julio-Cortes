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
            var person1 = new Person("Juan","Perez");
            Console.WriteLine(person1.Cachipun());
            var person2 = new Person("Pedro","Rodriguez");
            Console.WriteLine(person2.Cachipun());
            var person3 = new Person();

        }
    }
}
