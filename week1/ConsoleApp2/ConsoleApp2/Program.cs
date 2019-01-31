using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2.6, 4.3);
            Console.WriteLine(rectangle.getP());
            Console.WriteLine(rectangle.getS());

        }
    }
}
