using HomeTask07._04.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask07._04.Models
{
    internal class Student
    {
        private static int _caunt = 1;
        private string _name;
        private string _surname;
        public int Id { get;  }


        public string Name
        {
            get { return _name; }
            set { if (value.Length >= 3) { _name = value; } }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public Student(string name,string surname)
        {
            Name=name.Capitalize();
            Surname=surname.Capitalize();
            Id =_caunt;
            _caunt++;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name:{Name}\nSurname:{Surname}\nId={Id}");
        }

        




    }
}
