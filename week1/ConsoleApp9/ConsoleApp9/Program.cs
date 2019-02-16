using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp9
{
    class Program
    {
        public static void CreateCopyDelete(string path, string path1)
        {
            string combined = Path.Combine(path, "text.txt");
            string combined1 = Path.Combine(path1, "text1.txt");
            StreamWriter sw = new StreamWriter(combined);
            sw.Write("jgdm");
            sw.Close();
            File.Copy(combined, combined1);
            File.Delete(combined);
        }
        public static void Main(string[] args)
        {
            CreateCopyDelete(@"C:\Users\Гульмира\Desktop\text1.txt", @"C:\Users\Гульмира\Desktop\text2.txt");
        }
    }
}
