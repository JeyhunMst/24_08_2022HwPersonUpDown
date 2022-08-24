using System;
using System.Collections.Generic;
using System.Text;

namespace PersonStudentTeacher.Models
{
    abstract class Person
    {
        private static int _id;
        public int Id { get; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (IsDigit(value))
                {
                    _name = value;
                }
                

            }
        }
        private string _surName;

        public string SurName
        {
            get { return _surName; }
            set
            {
                if (IsDigit(value))
                {
                    _surName = value;
                }

            }
        }
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set 
            {
                if (value>0 && value<170)
                {
                    _age = value;

                }
            }
        }


        private bool IsDigit(string value) 
        {
            int count = 0;
            foreach (char item in value)
            {
                if (Char.IsDigit(item))
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                return true;

            }
            return false;
        }
        public abstract void ShowInfo();
        public Person(string name,string surname,int Age)
        {
            _id++;
            Id = _id;
            Name = name;
            SurName = surname;
            this.Age = Age;
                


        }
        















    }
}
