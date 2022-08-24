using System;
using System.Collections.Generic;
using System.Text;

namespace PersonStudentTeacher.Models
{
    class GroupMate
    {
        private Student[] _students;
        public GroupMate(int length)
        {
            _students = new Student[length];
        }
        
        public Student this[int index] 
        {
            get 
            {
                if (index<_students.Length)
                {
                    return _students[index];
                }
                throw new Exception();
            }
            set 
            {
                if (index < _students.Length)
                {
                    
                    _students[index] = value;
                    return;
                }
                else if (index==_students.Length)
                {
                    Array.Resize(ref _students, _students.Length + 1);
                    _students[index] = value;
                    return;


                }
                throw new Exception();

            }
        
        }
        public void Sort() 
        {
            for (int i = 0; i < _students.Length; i++)
            {
                int max = i;
                for (int j = i+1; j < _students.Length; j++)
                {
                    if (_students[i]<_students[j])
                    {

                        _students[j] = _students[i];
                        _students[max] = _students[j];


                    }

                }
            }
        }
        public void ShowInfo() 
        {
            foreach (Student item in _students)
            {
                item.ShowInfo();
            }
        }
        
    }
}
