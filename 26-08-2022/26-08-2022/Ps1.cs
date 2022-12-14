using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace application
{
    public struct Student
    {
        public int Id;
        public string Name;
        public string Dept;
        public int Age;

        public void SetStudent(int id, string name, string department, int age)
        {
            Id = id;
            Name = name;
            Dept = department;
            Age = age;
        }

        public void PrintStudent()
        {
            Console.WriteLine("Student details:");
            Console.WriteLine("\tID     : " + Id);
            Console.WriteLine("\tName   : " + Name);
            Console.WriteLine("\tDepartment   : " + Dept);
            Console.WriteLine("\tAge  :" +Age);
            Console.WriteLine("\n");
        }
    }
    class Ps1
    {
        static void Main(string[] args)
        {
            Student[] S = { new Student(), new Student() };

            S[0].SetStudent(001, "Sanjay", "IT",22);
            S[1].SetStudent(002, "Ajay", "Mech");

            S[0].PrintStudent();
            S[1].PrintStudent();
        }
    }
}