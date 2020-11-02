using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parts
    {
       protected internal int Wheel;
        protected internal string Motar;
        
        protected internal void DisplayParts()
        {
            Console.WriteLine("Wheel:{0}||Motor:{1}", Wheel, Motar);
        }
    }

    class ProtectedInternalEg
    {
    }
}
