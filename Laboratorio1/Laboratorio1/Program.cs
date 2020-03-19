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
            Person person1 = new Person("Bob", "Kunga");
            Console.WriteLine(person1.Cachipun());
            Console.WriteLine(person1.Name + " "+ person1.LastName);           
        }
    }
}
