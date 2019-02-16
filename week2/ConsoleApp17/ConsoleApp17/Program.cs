Baqytnuruly Yerassyl, [07.02.19 17:21]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace example
{
    class Program
    {
        public static void CreateCopyDelete(string path, string path1)
        {
            string combined = Path.Combine(path, "text.txt");
            string combined1 = Path.Combine(path1, "text1.txt");
            StreamWriter sw = new StreamWriter(combined);
            sw.Write("sfafsd");
            sw.Close();
            File.Copy(combined, combined1);
            File.Delete(combined);
        }
        public static void Main(String[] args)
        {
            CreateCopyDelete(@"C:\Users\Гульмира\Desktop\pp2", @"C: \Users\Гульмира\Desktop");

        }
    }
}
