using Exercise01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Entities
{
    public class Student : User, IStudent
    {
        public int Grades { get; set ; }


        public Student(int id, string name, string username, string password, int grades) : base(id, name, username, password)
        {
            Grades = grades;
        }
        public override void PrintUser()
        {
            Console.WriteLine(Grades);
        }   
    }
}
