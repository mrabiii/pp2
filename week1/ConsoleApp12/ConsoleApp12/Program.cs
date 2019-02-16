using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Student
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("aaa", "bb");
            Console.WriteLine(student.getName());
            Console.WriteLine(student.getID());
            Console.WriteLine(student.Increment());
        }
    }
}
