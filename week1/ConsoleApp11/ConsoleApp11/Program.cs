using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp11
{
    class Program
    {
        static void print(DirectoryInfo d, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileInfo[] fileInfos = d.GetFiles(); //массив из директорий и файлов
            DirectoryInfo[] directoryInfos = d.GetDirectories(); //содержит информацию по директории
            FileSystemInfo[] fsis = new FileSystemInfo[fileInfos.Length + directoryInfos.Length]; //содержит информицию про файлы
            directoryInfos.CopyTo(fsis, 0); //копирует
            fileInfos.CopyTo(fsis, directoryInfos.Length);
            for (int i = 0; i < fsis.Length; i++)
            {
                if (i == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (fsis[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(i + 1 + "." + fsis[i].Name);
            }
        }

        public static void Main(string[] args)
        {
            string path = @"C:\Users\Гульмира\Desktop";
            DirectoryInfo d = new DirectoryInfo(path);
            int cursor = 0;
            int n = d.GetFileSystemInfos().Length;
            while (true) 
            {
                FileInfo[] fileInfos = d.GetFiles();
                DirectoryInfo[] directoryInfos = d.GetDirectories();
                FileSystemInfo[] fsis = new FileSystemInfo[fileInfos.Length + directoryInfos.Length];
                directoryInfos.CopyTo(fsis, 0);
                fileInfos.CopyTo(fsis, directoryInfos.Length);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor == -1)
                    {
                        cursor = n - 1;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                    {
                        cursor = 0;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        d = new DirectoryInfo(fsis[cursor].FullName);
                        cursor = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(fsis[cursor].FullName);
                        Console.Clear();
                        Console.WriteLine(sr.ReadToEnd());
                        sr.Close();
                        Console.ReadKey();
                    }
                }
                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (d.Parent != null)
                    {
                        d = d.Parent;
                        cursor = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                    else
                    {
                        break;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Delete)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        if (new DirectoryInfo(fsis[cursor].FullName).GetFileSystemInfos().Length == 0)
                        {
                            Directory.Delete(fsis[cursor].FullName);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Are you sure? If yes then type Y if no type any other key");
                            if (Console.ReadKey().Key == ConsoleKey.Y)
                            {
                                Directory.Delete(fsis[cursor].FullName, true);
                            }
                        }
                    }
                }
                if (keyInfo.Key == ConsoleKey.R)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string Name = fsis[cursor].Name;
                        string fName = fsis[cursor].FullName;
                        string newpath = "";
                        for (int i = 0; i < Name.Length - Name.Length; i++)
                        {
                            newpath = newpath + s;
                            Directory.Move(fName, newpath);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string Name = fsis[cursor].Name;
                        string fName = fsis[cursor].FullName;
                        string newpath = "";
                        for (int i = 0; i < fName.Length - Name.Length; i++)
                        {
                            newpath += fName[i];
                        }
                        newpath = newpath + s;
                        File.Move(fName, newpath);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                print(d, cursor);
            }
        }
    }
}
