using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp7
{
    class Program
    {
        public static bool isPrime(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Гульмира\Desktop\text3");
            string[] arr = sr.ReadToEnd().Split(' ');

            StreamWriter sw = new StreamWriter(@"C:\Users\Гульмира\Desktop\text3");
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(int.Parse(arr[i])))
                {
                    res += arr[i] + ' ';
                }
            }
            sw.Write(res);
            sw.Close();
        }
    }
}
