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
        public Person()//Default constructor
        {
        
        }
        public Person(string name,string lastname)
        {
            this.LastName = lastname;
            this.Name = name;
        }
        public int Cachipun()
        {
            var random = new Random ();
            return random.Next(0, 3);
        }

    }
}
    