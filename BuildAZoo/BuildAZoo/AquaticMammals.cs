using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class AquaticMammals : Aquatic
    {
        string Flippers { get; set; }

        public void Swimming()
        {
            Console.WriteLine("Lets keep swimming swimming");
        }
    }

}
