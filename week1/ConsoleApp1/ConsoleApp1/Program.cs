using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool isPrime(int n) //create function to check for prime 
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);  //transfer from string to int
            List<int> numbers = new List<int>(); //create dinamic array
            string k = Console.ReadLine(); //read k
            string[] q = k.Split(' '); //splits spacing from numbers
            for (int i = 0; i < q.Length; i++)
            {
                int num = int.Parse(q[i]);
                if (isPrime(num) == true && num!=1)
                {
                    numbers.Add(num); //add number in the back
                }
            }
            Console.WriteLine(numbers.Count);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                Console.Write(' ');
            }
            Console.ReadKey(); //close console by pressing the button
        }
    }
}
