using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolApp_Noorkhzaimiah
{ 
public sealed class Manager
{
    public string name;
    public int Managerid;
    
    //  manager is singelton class : 
    private static Manager instance = null;
    public static Manager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Manager();
            }
            return instance;
        }
    }

    public void addnewcourse(course cours, Student st1, Student st2, Student st3)
    {//at least course must have 3 studnts , so manager add this three  
     // and afterthat he can add more by addstudent method 
        course co = cours;
        co.addstudent(st1);
        co.addstudent(st2);
        co.addstudent(st3);
    }
    public void addstudent_to_existcourse(Student st, course co)
    {
        co.addstudent(st);
    }
    public void removestudent_to_existcourse(Student st, course co)
    {
        co.removestudent(st);
    }
    public void printinfo_of_exist_course(course co)
    {

        co.printcourseinfo(co);


    }
    public void changeteacher_of_exist_course(course co, Teacher newte)
    {

        co.changeTeacher(co, newte);


    }


}
}