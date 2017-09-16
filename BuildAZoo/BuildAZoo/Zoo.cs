using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Zoo
    {
        string CareTakers { get; set; }


        public abstract void CleanUp();
        public abstract void Feed();
       
    }
}
