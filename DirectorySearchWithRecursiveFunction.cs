using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class DirectorySearchWithRecursiveFunction
    {

        static void Main(string[] args)
        {
            String searchName = "win";
            DirectoryInfo dir = new DirectoryInfo(@"c:\Program Files");
            SearchDirectories(dir, searchName);
        }
        public static void SearchDirectories(DirectoryInfo dir,String target)
        {
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                // Check if name is in any files
                if (file.Name.StartsWith(target))
                {
                    Console.WriteLine(file.Name);
                }
            }
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
            {
                SearchDirectories(subDir, target);
            }
        }
    }
}

