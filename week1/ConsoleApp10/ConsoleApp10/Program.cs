using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string[] arr = a.Split();
            int[] output = new int[2 * n];
            int cnt = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                cnt++;
                output[cnt] = int.Parse(arr[i]);
                cnt++;
                output[cnt] = int.Parse(arr[i]);
            }

            foreach (int i in output)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
