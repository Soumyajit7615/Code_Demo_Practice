using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class FileAndDirectoryInfoDemo
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{

            //    Directory.CreateDirectory(@"E:\INTADM22DF043\DEMO\MyDir" + i);
            //}

            DirectoryInfo directoryInfo = new DirectoryInfo(@"E:\INTADM22DF043\DEMO");
            //string[] names = { "Ankita", "Akshara", "Pravin", "Ajay", "Sanchaita", "Sukesh" };

            //foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            //{
            //    Console.WriteLine(dir.FullName);
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        //File.Create(dir.FullName + @"\File" + i + ".txt");

            //        File.WriteAllLines(dir.FullName + @"\File" + i + ".txt", names);
            //    }
            //}


            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                Console.WriteLine(dir.FullName);
                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine(file.FullName);
                }



            }
        }
    }
}
