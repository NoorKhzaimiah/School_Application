using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolApp_Noorkhzaimiah
{
    public class course
    {
        public int id;
        public string name;
        public Teacher teacher;
        public List<Student> Students;
        public List<grade> grades;

        public void addstudent(Student st)
        {
            Students.Add(st);
        }
        public void removestudent(Student st)
        {
            Students.Remove(st);
        }
        public void printcourseinfo(course co)
        {
            Console.WriteLine("Teacher of this course is : " + co.teacher);
            foreach (Student stu in Students)
                Console.WriteLine("Student : " + stu.name);
        }
        public void changeTeacher(course co, Teacher newte)
        {
            co.teacher = newte;
        }



    }
   
}
