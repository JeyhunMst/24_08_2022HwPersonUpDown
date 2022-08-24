using System;
using System.Collections.Generic;
using System.Text;

namespace PersonStudentTeacher.Models
{
    class Student : Person
    {
        private float _point;

        public float Point
        {
            get { return _point; }
            set 
            {
                if (value>=0 && value<=100)
                {
                    _point = value;
                }
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Student name:{Name} Surname:{SurName} Age:{Age} Point of student:{Point}  Id:{Id}");

        }
        public Student(string name,string surname,int age,float point):base(name,surname,age)
        {
            Point = point;

        }
        public static bool operator >(Student studentNo1, Student studentNo2) 
        {
            if (studentNo1.Point > studentNo2.Point)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Student studentNo1, Student studentNo2)
        {
            if (studentNo1.Point < studentNo2.Point)
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
