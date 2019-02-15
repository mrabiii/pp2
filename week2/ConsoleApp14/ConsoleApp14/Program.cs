using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace ConsoleApp6
{
    class Program
    {
        public static bool isPol(string s) //create function to check for polindrome
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(String[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Гульмира\Desktop\text.txt"); //reads file
            string s = sr.ReadToEnd();
            sr.Close(); //closes sr
            if (isPol(s)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey();
        }

    }
}