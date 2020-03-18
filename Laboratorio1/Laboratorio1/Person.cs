using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Person
    {
        public string Name;
        public string LastName;
        public void Cachipun()
        {
            var random = new Random ();
            Console.WriteLine (random.Next(0, 2));
        }

    }
}
    