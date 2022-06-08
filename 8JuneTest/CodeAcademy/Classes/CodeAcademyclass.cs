using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAcademy.Classes
{
    class CodeAcademyclass
    {
        public CodeAcademyclass()
        {
            Groups = new Group[0];
            _groupLimit = 10;
        }
        public Group[] Groups;
        private int _groupLimit;
        public int GroupLimit { get => _groupLimit;
        }

        public void AddGroup(Group group)
        {
            if (_groupLimit> Groups.Length)
            {
                Array.Resize(ref Groups, Groups.Length + 1);
                Groups[Groups.Length - 1] = group;
            }
        }
        public string WhichSpecialty(Group group)
        {
            string str;
            if (group is ProgrammingGroup)
            {
                str = $"{group.GroupName} group is Programming group, and {group.Students.Length} students studying in this group";
                Console.WriteLine(str);
            }
            else if (group is DesignGroup)
            {
                str = $"{group.GroupName} group is Design group, and {group.Students.Length} students studying in this group";
                Console.WriteLine(str);
            }
            else
            {
                str = "No such group found in Code Academy";
                Console.WriteLine(str);
            }
            return str;
        }
    }
}
