using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool isPrime(int n)
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
            int n = int.Parse(s);
            List<int> numbers = new List<int>();
            string k = Console.ReadLine();
            string[] q = k.Split(' ');
            for (int i = 0; i < q.Length; i++)
            {
                int num = int.Parse(q[i]);
                if (isPrime(num) == true)
                {
                    numbers.Add(num);
                }
            }
            Console.WriteLine(numbers.Count);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                Console.Write(' ');
            }
        }
    }
}
