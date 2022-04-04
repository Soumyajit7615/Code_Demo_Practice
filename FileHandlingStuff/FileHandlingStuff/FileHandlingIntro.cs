using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class FileHandlingIntro
    {
        static void Main(string[] args)
        {
            DirectoryInfo info = new DirectoryInfo(@"C:\Users\soumyajit das\myfile");

            foreach (DirectoryInfo dir in info.GetDirectories())
            {
                Console.WriteLine(dir.FullName);

                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
                Console.WriteLine();
            }


        }
    }
}
