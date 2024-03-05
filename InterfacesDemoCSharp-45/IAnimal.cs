using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoCSharp_45
{
    public interface IAnimal
    {
        //Cannot have fields in an interface

        public string Diet { get; set; }
        public int Age { get; set; }

        //Interface methods will ALWAYS be stubbed out methods
        //In the background interfaces are completely abstract (even though we never actually use the word "abstract")
        public void Move();
        public void Breathe();
    }
}
