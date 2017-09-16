using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class KillerWhale : AquaticMammals
    {
        public override void CleanUp()
        {
            Console.WriteLine("Cleaning up the Whales");
        }
        public override void Feed()
        {
            Console.WriteLine("Throw me a Seal for fun!");
        }
    }

}
