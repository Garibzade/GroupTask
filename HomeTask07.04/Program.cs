using HomeTask07._04.Models;
using System.Reflection;

namespace HomeTask07._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("samir","qasimov");
            //Student student1 = new Student("rauf", "Dosduyev");
            //Student student2 = new Student("emil", "akula");
            //Student student3 = new Student("eli", "eliyev");
            //Student student4 = new Student("ibrhm", "katanova");
            //Student student5 = new Student("sahin", "alizade");

            //student.GetInfo();
            //student1.GetInfo();
            //student2.GetInfo();
            //student3.GetInfo();
            //student4.GetInfo();
            //student5.GetInfo();

            Student student=new Student("emil","akulaapk");

            Student student2 = new Student("Ali", "asda");
            Student student3 = new Student("sahin", "alizade");
            Student student4 = new Student("samir", "kerimov");
            Group group = new Group("AB-106");
            Group group1 = new Group("Ab-105");

            group1.Addstudent(student);
            group1.Addstudent(student2);

            Group.AddGroup(group1);

            student.GetInfo();
            
            group.Addstudent(student);
            Group.RemoveGroup(2);
            
           
            

        }
    }
}
