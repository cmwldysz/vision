using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study10_16json操作
{
    class Student
    {
        private int _studentID;
        private string _studentName;
        private string _className;

        public int StudentID { get => _studentID; set => _studentID = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public string ClassName { get => _className; set => _className = value; }
    }
}
