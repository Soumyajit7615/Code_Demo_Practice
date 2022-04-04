using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingStuff
{
    class Employee
    {
        public int EMPCODE { get; set; }
        public string EMPNAME { get; set; }
        public int EMPDEPT { get; set; }

    }
    class ReadingCSVFileDemo
    {
        static void Main(string[] args)
        {
            string strLine = "";
            string[] strArr;
            int count = 0;
            List<Employee> EmployeeList = new List<Employee>();

            using (StreamReader sr = new StreamReader(@"C:\Users\soumyajit das\practice\Employees.csv"))
            {
                while ((strLine = sr.ReadLine()) != null)
                {
                    if (count != 0)
                    {
                        strArr = strLine.Split(',');
                        EmployeeList.Add(
                            new Employee()
                            {
                                EMPCODE = Convert.ToInt32(strArr[0]),
                                EMPNAME = strArr[1],
                                EMPDEPT = Convert.ToInt32(strArr[2])
                            }
                            );
                    }
                    count++;
                    //Console.WriteLine(strLine);
                }
                foreach (Employee emp in EmployeeList)
                {
                    Console.WriteLine(emp.EMPCODE + " " + emp.EMPCODE.GetType());
                    Console.WriteLine(emp.EMPNAME + " " + emp.EMPNAME.GetType());
                    Console.WriteLine(emp.EMPDEPT + " " + emp.EMPDEPT.GetType());

                    Console.WriteLine();
                }
            }


        }
    }
}
