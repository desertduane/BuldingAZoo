using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Tarantula : Insect
    {
        public override void CleanUp()
        {
            Console.WriteLine("Tarantulas are easy to clean");
        }

        public override void Feed()
        {
            Console.WriteLine("Gimme those crickets");
        }
        public void Bite()
        {
            Console.WriteLine("I am actually a very friendly spider");
        }
    }
}
