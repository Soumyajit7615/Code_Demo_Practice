using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class Program
    {
        static void Main(string[] args)
        {


            if (!File.Exists("Hello.txt"))
            {
                 File.Create("Hello.txt");

            }
            else
            {
                File.Delete("Hello.txt");
            }
            

            string[] NameList =
                 {"Rachana Pangantiwar",
                "Aniket Dhawas",
                "Vaishnavi Nawkhare",
                "Harsh Singh",
                "Sakshi Taral",
                "Sakshi Malani",
                "Aryan Gupta",
                "Diksha Sharma",
                "Suryansh Dubey",
                "Sanskriti Dubey",
                "Vikram Joshi",
                "Riddhi Deshmukh",
                "Anand Kalpe",
                "Ranjandeep Singh",
                "Aditya Nandgirwar",
                "Someshwar Bhadange",
                "Supreet Ganguly",
                "Priti Sarote",
                "Aman Kumar",
                "Avinash Singh",
                "Tanvi Gaurkhede",
                "Shishir Deshmukh",
                "Manish Thakkurwar"};
            File.WriteAllLines(@"Hello.txt", NameList);

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Hewlett Packard\source\repos\ADM21DF010\FileHandlingStuff\FileHandlingStuff");
            foreach (FileInfo  file in directoryInfo.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
           

        }
    }
}
