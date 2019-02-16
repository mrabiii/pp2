using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp10
{
    class FarManager
    {
        public int cursor;
        public int sz;
        bool ok;
        public FarManager()
        {
            cursor = 0;
            ok = true;
        }

        public void Up()
        {
            cursor--;
            if (cursor < 0)
            {
                cursor = sz - 1;
            }
        }

        public void Down()
        {
            cursor++;
            if (cursor == sz)
            {
                cursor = 0;
            }
        }

        public void Color(FileSystemInfo fs, int index)
        {
            if (index == cursor)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Dlack;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroungColor = ConsoleColor.Magenta;
            }
        }
        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] fileSystemInfo = directory.GetFileSystemInfos();
            sz = fileSystemInfos.Length;
            int index = 0;
            foreach (FileSystemInfos fs in fileSystemInfos)
            {
                if (ok && fs.Name.StartWith("."))
                {
                    sz--;
                    continue;
                }
                Color(fs, index)

                Console.WriteLine(fs.Name);
                index++;
            }
        }

        public void Start(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            FileSystemInfo fs = null;
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.Escape)
                {
                    cursor = 0;
                    directory = directory.Parent;
                    path = directory.FullName;
                }
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow)
                    ok = false;
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                    ok = true;
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    int k = 0;
                    for (int i = 0; i < directory.GetFileSystemInfos().Length; i++)
                    {
                        if (ok && directory.GetFileSystemInfos()[i].Name.StartsWith("."))
                            continue;
                        if (cursor == k)
                        {
                            fs = directory.GetFileSystemInfos()[i];
                            break;
                        }
                        k++;
                    }
                    if (fs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        directory = new DirectoryInfo(fs.FullName);
                        path = fs.FullName;
                    }
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        FarManager farManager = new FarManager();
        FarManager.Start("C:\Users\Гульмира\Desktop");
    }
}

}