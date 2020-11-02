using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    interface ICar
    {
        int Break();
        string Engine();
    }
    class Benz : ICar
    {
        public string Engine()
        {
            return "v6";
        }
        public int Break()
        {
            return 4;
        }
        
       
        internal void BenzFunctionality()
        {
            Console.WriteLine("Excellent");
        }
    }
    class Toyota : ICar
    {
        public string Engine()
        {
            return "v7";
        }
        public int Break()
        {
            return 3;
        }
        
        internal void ToyotaFunctionality()
        {
            Console.WriteLine("Good");
        }
    }
    class Day4Practice
    {
        static void Main()
        {
            Benz benz = new Benz();
            Console.WriteLine(benz.Engine());
            Console.WriteLine(benz.Break());
            benz.BenzFunctionality();
            Toyota toyota = new Toyota();
            Console.WriteLine(toyota.Engine());
            Console.WriteLine(toyota.Break());
            toyota.ToyotaFunctionality();
            
            Console.Read();
        }
    }
}



