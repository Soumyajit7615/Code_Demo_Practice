using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingStuff
{
    class ReadingContentOfTheFile
    {
        static void Main(string[] args)
        {
            string strLine = "";


            using (StreamReader sr = new StreamReader("Hello.txt"))
            {
                while ((strLine = sr.ReadLine()) != null)
                {
                    Console.WriteLine(strLine);
                }
            }
            ////Write a string array to file.
            string[] stringArray = new string[]
            {
                "shubham","Jyoti","Swagat","Mayank"
            };
            File.WriteAllLines("MyData.txt", stringArray);
            ////Read in all lines from file
            foreach (string line in File.ReadAllLines("MyData.txt"))
            {
                Console.WriteLine(line);
            }


        }
    }
}
