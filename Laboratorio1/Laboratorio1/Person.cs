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
        public int Cachipun()
        {
            var random = new Random ();
            return random.Next(0, 2);
        }

    }
}
    