using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class FileStreamDemo
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"E:\GN22ADMDNFS001\CtsData.txt",
               FileMode.Append, FileAccess.Write, FileShare.None);

          
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("We are learning file stream:");
                Console.WriteLine("Press enter key to close the file");
                Console.ReadLine();
            }
            


        }
    }
}
