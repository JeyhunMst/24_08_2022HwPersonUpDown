using System;
using System.Collections.Generic;
using System.Text;

namespace PersonStudentTeacher.Models
{
    class Teacher : Person
    {
        private decimal _salary;
        private decimal Salary
        { get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Teacher's name:{Name}  Surname:{SurName} Age:{Age} Salary:{Salary} Id:{Id}");
        }
        public Teacher(string name, string surname, int age, decimal salary) : base(name, surname, age)
        {
            Salary = salary;
        }
        public static bool operator >(Teacher teacherNo1, Teacher teacherNo2) 
        {
            if (teacherNo1.Salary > teacherNo2.Salary)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public static bool operator <(Teacher teacherNo1, Teacher teacherNo2) 
        {
            if (teacherNo1.Salary < teacherNo2.Salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
