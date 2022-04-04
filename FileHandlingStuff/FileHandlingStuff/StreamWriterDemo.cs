using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class StreamWriterDemo
    {
        static void Main(string[] args)
        {

            using (StreamWriter sw = new StreamWriter(@"C:\Users\soumyajit das\practice\MyFile.txt"))
            {
                sw.WriteLine("Hello and Welcome to CTS");

            }

        }
    }
}
