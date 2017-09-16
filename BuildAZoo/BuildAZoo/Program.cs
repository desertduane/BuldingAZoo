using System;

namespace BuildAZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm an Orca!");

            KillerWhale killerWhale = new KillerWhale();

            killerWhale.CleanUp();
            killerWhale.Feed();
            killerWhale.Swimming();

            Console.WriteLine("");
            Console.WriteLine("I'm the Biggest Seal on the Planet");

            ElephantSeal elephantSeal = new ElephantSeal();

            elephantSeal.Swimming();
            elephantSeal.CleanUp();
            elephantSeal.Speak();
            elephantSeal.Feed();

            Console.WriteLine("");

            BullShark bullShark = new BullShark();

            Console.WriteLine("Most dangerous shark even freshwater doesn't phase me");

            bullShark.Bite();
            bullShark.CleanUp();
            bullShark.Feed();
            bullShark.Swimming();

            Console.WriteLine("");

            Console.WriteLine("I am a large Snake not the coding language thanks!");

            Python python = new Python();

            python.Legs = 0;
            Console.WriteLine(python.NumberOfLegs());
            python.Hunt();
            python.Feed();
            python.CleanUp();

            Console.WriteLine("");
            Tarantula tarantula = new Tarantula();
            Console.WriteLine("The heaviest spider there is");

            tarantula.CleanUp();
            tarantula.Feed();
            tarantula.Legs = 8;
            Console.WriteLine(tarantula.NumberOfLegs());
            tarantula.Bite();

            Console.WriteLine("");

            Lion lion = new Lion();
            Console.WriteLine("King of the jungle");

            lion.CleanUp();
            lion.Feed();
            lion.Legs = 4;
            Console.WriteLine(lion.NumberOfLegs());
            lion.Bite();




            Console.Read();

        
        }
    }
}
