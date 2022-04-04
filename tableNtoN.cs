using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingStuff
{
    class tableNtoN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The table from 2 to 1000:");
            for (int i = 2; i <=1000; i++)
            {
                Console.WriteLine($"The table of :{i}");
                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i*j}");

                }
                Console.WriteLine();
            }
        }
    }
}
