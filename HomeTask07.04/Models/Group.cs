using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeTask07._04.Models
{
    internal class Group
    {
        private static int _count = 1;
        public static Group[] Groups =new Group[0];
        public int GroupId { get; }
        public string GroupName { get; }
        public  Student[] Students = new Student[0];


        public Group(string groupname)
        {
            GroupName = groupname;
            Students = new Student[0];
            Groups = new Group[0];
            GroupId = _count;
            _count ++;

        }
        public  void GetGroupInfo()
        {
            Console.WriteLine($"Group Id:{GroupId}\nGroup Name:{GroupName}\n");
            foreach( var student in Students ) 
            {
                student.GetInfo(); 
            }
        }
       public Student GetStudent(int id)
        {
            foreach( var student in Students )
            {
                if (student.Id == id)
                {
                   return student;
                }
            }
            return null;
        }

        

        public void Addstudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1); 
            Students[Students.Length - 1] = student;
        }

        
        public void Search(string query)
        {
              query = Console.ReadLine();
            foreach ( var student in Students )
            {
                if (student.Name == query && student.Surname==query)
                {
                     student.GetInfo();
                }
            }
            Console.WriteLine("bele bir telebe yoxdur");
        }
        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                student.GetInfo();
            }
        }
        public override string ToString()
        {
            return  $"Group Id: {GroupId}, Group Name: {GroupName}, Student Count: {Students.Length}";
        }
        public static void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1); 
            Groups[Groups.Length - 1] = group;
        }
        public static void RemoveGroup(int id)
        {
            Group[] newArr = new Group[Groups.Length-1];
            int j=0;
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].GroupId!=id)
                {
                    newArr[j] = Groups[i];
                    j++;
                }
            }
            Groups = newArr;
        }
         public static Group GetGroup(int id)
        {
            foreach(var group in Groups)
            {
                if (group.GroupId == id)
                {
                    return group;
                }
            }
            return null;
        }
    }
}
