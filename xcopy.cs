using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class xcopy
    {
        static void Main(string[] args)
        {
            string line = "";
            for (int i = 1; i < args.Length; i++)
            {
                using (StreamReader sourcereader = new StreamReader(args[0]))
                {
                    while ((line = sourcereader.ReadLine()) != null)
                    {
                        using (StreamWriter destinationToCopy = new StreamWriter(args[i], true))
                        {
                            destinationToCopy.WriteLine(line);
                        }

                    }
                }
            }
            Console.WriteLine($"        {args.Length - 1} file(s) copied.");
            
        }
    }
}
