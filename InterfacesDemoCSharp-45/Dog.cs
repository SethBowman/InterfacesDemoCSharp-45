using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoCSharp_45
{
    public class Dog : IAnimal, IDog
    {
        public string Diet { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public void Breathe()
        {
            Console.WriteLine("Dog breathes with its tongue out");
        }

        public void BurySomething()
        {
            Console.WriteLine("Dog buries something");
        }

        public void Move()
        {
            Console.WriteLine("Dog runs");
        }
    }
}
