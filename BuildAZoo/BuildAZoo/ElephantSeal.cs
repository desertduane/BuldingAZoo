using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class ElephantSeal : AquaticMammals
    {
        public override void CleanUp()
        {
            Console.WriteLine("Clean up my mess!!");
        }
        public override void Feed()
        {
            Console.WriteLine("Throw me a salmon yum!");
        }
        public void Speak()
        {
            Console.WriteLine("ARF ARF ARF!");
        }
    }
}
