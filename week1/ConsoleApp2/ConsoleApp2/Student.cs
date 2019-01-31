using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        private string name;
        public string id;
        public int yearofstudy;

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
            yearofstudy = 0;
        }

        public string getName()
        {
            return this.name;
        }
        public string getID()
        {
            return this.id;
        }
        public int Increment()
        {
            return ++yearofstudy;
        }
    }
}
