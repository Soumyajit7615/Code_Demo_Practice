using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class FindingCommonNameFromFile
    {
        static void Main(string[] args)
        {

            List<string> Appraisal2019 = new List<string>();
            List<string> Appraisal2020 = new List<string>();
            List<string> Appraisal2021 = new List<string>();

            string strLine = "";
            char[] NameChar;
            using (StreamReader sr = new StreamReader("Appraisal2019.txt"))
            {
                while ((strLine = sr.ReadLine()) != null)
                {
                    NameChar = strLine.ToLower().ToCharArray();
                    Console.Write(strLine + " : ");
                    foreach (char ch in NameChar)
                    {

                        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        {
                            Console.Write(" {0}", ch);
                        }
                    }
                    Appraisal2019.Add(strLine.Trim());
                    Console.WriteLine();
                }
            }
            using (StreamReader sr = new StreamReader("Appraisal2020.txt"))
            {
                while ((strLine = sr.ReadLine()) != null)
                {
                    Appraisal2020.Add(strLine.Trim());
                }
            }
            using (StreamReader sr = new StreamReader("Appraisal2021.txt"))
            {
                while ((strLine = sr.ReadLine()) != null)
                {
                    Appraisal2021.Add(strLine.Trim());
                }
            }

            var commonnames = Appraisal2019.Intersect(Appraisal2020).Intersect(Appraisal2021);

            Console.WriteLine("List of person those are waiting for Appraisal , last three year are as follows :");
            int Counter = 1;
            foreach (string name in commonnames)
            {
                Console.WriteLine(Counter + ". " + name);
                Counter++;
            }
            //See details about FileStream in FileStreamDemo
            //FileStream fs = new FileStream(@"E:\GRASKO\filehandlingDemo\AppraisalCurrentYear.txt",
            //   FileMode.Create, FileAccess.Write, FileShare.None);
            if (File.Exists(@"E:\INTADM22DF043\DEMO\AppraisalCurrentYear.txt"))
            {
                File.Delete(@"E:\INTADM22DF043\DEMO\AppraisalCurrentYear.txt");
            }
            var result = commonnames.Select(x => x);
            foreach (string name in commonnames)
            {
                using (StreamWriter sw = new StreamWriter(@"E:\INTADM22DF043\DEMO\AppraisalCurrentYear.txt", true))
                {
                    sw.WriteLine(name);


                }

            }


        }
    }

}
  