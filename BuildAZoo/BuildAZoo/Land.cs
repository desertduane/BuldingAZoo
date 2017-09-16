using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Land : Zoo
        
    {
        public int Legs { get; set; }

        public int NumberOfLegs()
        {
            int legs = Legs;
            
            return legs;
        }
    }
}
