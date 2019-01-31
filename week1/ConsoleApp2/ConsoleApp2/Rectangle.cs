using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle
    {
        public double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double getP()
        {
            return (a + b) * 2;
        }

        public double getS()
        {
            return a * b;
        }

    }
}
