using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAcademy.Classes
{
    abstract class Group
    {
        public Group()
        {
            Students = new Student[0];
        }
        public Student[] Students;
        public string GroupName;
        public string Specialty;


    }
}
