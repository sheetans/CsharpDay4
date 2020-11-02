using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class AICTE
    {
        protected string Rule1 = "Standard Education";
        protected string Rule2 = " Activity Session";

        class MumbaiUniversity : AICTE
        {
            int idno = 10, TotalSeats = 700;

            protected void DisplayMumbaiUni()
            {
                Console.WriteLine(" idno:{0}||TotalSeats:{1}||Rule1:{2}||Rule2:{3}", idno, TotalSeats, Rule1, Rule2);
            }

            static void Main()
            {
                MumbaiUniversity mumbaiUniversity = new MumbaiUniversity();
                mumbaiUniversity.DisplayMumbaiUni();

                Console.Read();
            }


            class AnnaUniversity : AICTE
            {
                int idno = 12, TotalSeats = 760;

                protected void DisplayAnnaUni()
                {
                    Console.WriteLine(" idno:{0}||TotalSeats:{1}||Rule1:{2}||Rule2:{3}", idno, TotalSeats, Rule1, Rule2);
                }
            }
        }
        class InheritanceEg
        {

        }
    }
}

