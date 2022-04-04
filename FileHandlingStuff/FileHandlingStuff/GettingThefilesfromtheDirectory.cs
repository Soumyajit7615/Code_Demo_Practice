using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class GettingThefilesfromtheDirectory
    {
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Hewlett Packard\source\repos\ADM21DF010");
            SearchDirectories(dir);




        }

        static void SearchDirectories(DirectoryInfo dir)
        {
            FileInfo[] files = dir.GetFiles();
            Console.WriteLine(dir.FullName);

            Console.WriteLine(dir.CreationTime);
            foreach (FileInfo file in files)
            {
                if (file.Extension == ".cs")
                {
                    Console.WriteLine(file.Name);
                }



            }
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subdir in dirs)
            {
                SearchDirectories(subdir);
            }



        }
    }
}
