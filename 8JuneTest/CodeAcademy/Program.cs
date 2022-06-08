using CodeAcademy.Classes;
using CodeAcademy.Extentions;
using System;

namespace CodeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student() { FullName = "Elnur Khalilov", Age = 21, Point = 100 };
            //Student student2 = new Student() { FullName = "Elnur2 Khalilov", Age = 22, Point = 40 };
            //Student student3 = new Student() { FullName = "Elnur3 Khalilov", Age = 23, Point = 60 };
            //Student[] students = { student1, student2, student3 };

            //DesignGroup d112 = new DesignGroup() { GroupName = "D112", DesignApp = "Illustrator", Specialty = "Graphic Design", Students = students };

            //Student student4 = new Student() { FullName = "Elnur4 Khalilov", Age = 26, Point = 90 };
            //Student student5 = new Student() { FullName = "Elnur5 Khalilov", Age = 29, Point = 30 };
            //Student student6 = new Student() { FullName = "Elnur6 Khalilov", Age = 33, Point = 77 };
            //Student[] studentsProgramming = { student4, student5, student6 };

            //ProgrammingGroup p227 = new ProgrammingGroup() { GroupName = "P227", ProgrammingLanguage = "C#", Specialty = "Graphic Design", Students = students };

            //Group[] groups = { d112 };

            //CodeAcademyclass codeAcademy = new CodeAcademyclass() { Groups = groups };

            //codeAcademy.WhichSpecialty(d112);

            string name = "salam";
            int[] arr = name.FindHey('a');
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
