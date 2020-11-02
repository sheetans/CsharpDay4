using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4
{
    class Employee
    {
        protected int EmpID;
        protected string EmpName;
        protected float salaryperhour;
        internal Employee(int EmpID, string EmpName, float salaryperhour)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.salaryperhour = salaryperhour;
        }
    }
    class Parttimeemployee : Employee
    {
        int Hoursofworking;
        internal Parttimeemployee(int Eid, string Ename, float sph, int Hoursofworking) : base(Eid, Ename, sph)
        {
            this.Hoursofworking = Hoursofworking;
        }
        void CalculateSalary()
        {
            float salary = salaryperhour * Hoursofworking;
            Console.WriteLine("The salary of employee is {0}", salary);
        }
        void GetEmpDetails()
        {
            Console.WriteLine("Employee ID:{0},Employee Name:{1},Salary Per Hour :{2},Hours of Working:{3}", EmpID, EmpName, salaryperhour, Hoursofworking);
        }
        static void Main()
        {
            Parttimeemployee parttimeemployee = new Parttimeemployee(101, "Rahul", 200.9f, 20);
            parttimeemployee.CalculateSalary();
            parttimeemployee.GetEmpDetails();
            Console.Read();

        }
    }

    class QuestionOnEmployee
    {
    }
}
