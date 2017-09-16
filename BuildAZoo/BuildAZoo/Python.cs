using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Python : Reptile
    {
        public override void CleanUp()
        {
            Console.WriteLine("I eat once every couple months there for I poop only every few months");
        }

        public override void Feed()
        {
            Console.WriteLine("I will eat a whole hog");
        }
        public void Hunt()
        {
            Console.WriteLine("I squeeze my prey to death");
        }
    }
}
