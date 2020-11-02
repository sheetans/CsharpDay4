using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ interface ICar
    {
        void Break();
        void  Engine();
    }

    class Benz : ICar
    {
        void ICar.Break()
        {
            Console.WriteLine("Benz have good breaks");
        }
        void ICar.Engine()
        {
            Console.WriteLine("Benz have fast Engine");
        }

    }
    class Totota :ICar
    {
        void ICar.Break()
        {
            Console.WriteLine("Toyota have good breaks");
        }
        void ICar.Engine()
        {
            Console.WriteLine("Toyota have fast Engine");
        }
    }
    class Day4Practice
    {
    }
}
