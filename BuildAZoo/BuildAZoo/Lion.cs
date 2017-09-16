using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Lion : Mammal
    {
        public override void CleanUp()
        {
            Console.WriteLine("Lions take a lot of work");
        }

        public override void Feed()
        {
            Console.WriteLine("I love to eat red meat. No vegans here");
        }
        public void Bite()
        {
            Console.WriteLine("If your not careful I will bite!");
        }
    }
}
