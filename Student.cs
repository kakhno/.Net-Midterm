using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        private string StudentName {  get; set; }

        private int Grade { get; set; }

        public Student(string StudentName, int Grade)
        {
            this.StudentName = StudentName;
            this.Grade = Grade;
        }

        public string Greeting()
        {
            return ($"Hi, I'm {StudentName} and I'm in grade {Grade}");
        }

  
    }
}
