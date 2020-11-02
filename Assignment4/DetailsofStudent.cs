using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    
    abstract class Student
        {
            public string Name;
            public int StudentId;
            public int Grade;
            public abstract Boolean Ispassed(int Grade);
        }
    class Undergraduate: Student
    {
        public  override Boolean Ispassed(int Grade)
        {
            if(Grade>70)
           {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : Student
    {
        public override Boolean Ispassed(int Grade)
        {

            if (Grade > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    class DetailsOfStudent

    {
        static void Main()
        {
           
            Console.WriteLine("Enter the Undergraduate StudentDetails");
            Undergraduate ug = new Undergraduate();
            Console.WriteLine("enter undergraduate student name");
            ug.Name = Console.ReadLine();
            Console.WriteLine("enter undergraduate student id");
            ug.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter undergraduate student grade");
            ug.Grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Name:{0}||Student ID:{1}||Grade:{2}||Passed:{3}", ug.Name, ug.StudentId, ug.Grade, ug.Ispassed(Grade));
            Console.WriteLine("Enter the Graduate Student Details");
            Graduate g = new Graduate();
            Console.WriteLine("enter graduate student name");
            g.Name = Console.ReadLine();
            Console.WriteLine("enter graduate student id");
            g.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter graduate student grade");
            g.Grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Name:{0}||Student ID:{1}||Grade:{2}||Passed:{3}", g.Name, g.StudentId, g.Grade, g.Ispassed(Grade));
            Console.Read();

        }
    }
}

