using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp8
{
    class Program
    {
        public static void WhiteSpace(int level)
        {
            for (int i = 0; i < level * 4; i++)  //create array which make space before file

            {
                Console.Write(' ');
            }
        }

        public static void print(string path, int level)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileinfos = directoryInfo.GetFiles();
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            foreach (FileInfo f in fileinfos)
            {
                WhiteSpace(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in directoryInfos)
            {
                WhiteSpace(level);
                Console.WriteLine(d.Name);
                print(d.FullName, level + 1);
            }
        }
        public static void Main(String[] args)
        {
            print(@"C:\Users\Гульмира\Desktop\pp2", 0);
            Console.ReadKey();
        }
    }
}
