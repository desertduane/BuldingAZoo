using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class BullShark : Aquatic
    {
        public override void CleanUp()
        {
            Console.WriteLine("Keep my water fresh and I will be happy");
        }

        public override void Feed()
        {
            Console.WriteLine("Seals and smaller fish watch out");
        }
        public void Bite()
        {
            Console.WriteLine("The great white takes all the bad rep for my poor behavior I am a biter");
        }

        internal void Swimming()
        {
            Console.WriteLine("Fresh water aint got nothing on me");
        }
    }
}
