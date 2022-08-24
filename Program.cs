using PersonStudentTeacher.Models;
using System;

namespace PersonStudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student studentNo1 = new Student("Ceyhun", "Mustafayev", 16, 99);
                Student studentNo2 = new Student("Jack", "Sparrow", 22, 100);
                Teacher teacherNo1 = new Teacher("John", "McTavish", 24, 3000);
                Teacher teacherNo2 = new Teacher("Frank", "Castle", 36, 10000);
                GroupMate groupp326 = new GroupMate(3);
                Person personNo1 = studentNo1;
                Person personNo2 = teacherNo1;
                Person personNo3 = studentNo2;
                Person personNo4 = teacherNo2;
                Person[] persons = { personNo1, personNo2, personNo3, personNo4 };
                int count = 0;
                foreach (Person item in persons)
                {

                    if (item is Student student)
                    {
                        groupp326[count] = student;
                        count++;
                    }

                }
                studentNo1.ShowInfo();
                studentNo2.ShowInfo();
                teacherNo1.ShowInfo();
                teacherNo2.ShowInfo();
                groupp326.ShowInfo();

            }
            catch (NullReferenceException )
            {

                Console.WriteLine("Group is not fullfilled ,add additional students to group ");
            }
            catch (Exception ex ) 
            {
                Console.WriteLine(ex.Message);
            }

            



        }
    }
}
